//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using SQLite.Net.Async;
//using Xamarin.Forms;
//using PracticeWarning.Model;
//
//namespace PracticeWarning
//{
//	public sealed class AsyncLock
//	{
//		private readonly SemaphoreSlim m_semaphore = new SemaphoreSlim(1, 1);
//		private readonly Task<IDisposable> m_releaser;
//
//		public AsyncLock()
//		{
//			m_releaser = Task.FromResult((IDisposable)new Releaser(this));
//		}
//
//		public Task<IDisposable> LockAsync()
//		{
//			var wait = m_semaphore.WaitAsync();
//			return wait.IsCompleted ?
//				m_releaser :
//				wait.ContinueWith((_, state) => (IDisposable)state,
//					m_releaser.Result, CancellationToken.None,
//					TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
//		}
//
//		private sealed class Releaser : IDisposable
//		{
//			private readonly AsyncLock m_toRelease;
//			internal Releaser(AsyncLock toRelease) { m_toRelease = toRelease; }
//			public void Dispose() { m_toRelease.m_semaphore.Release(); }
//		}
//	}
//	public interface ISQLite {
//		SQLiteAsyncConnection GetConnection();
//	}
//
//	public class SQLiteClient
//	{
//		private static readonly AsyncLock Mutex = new AsyncLock ();
//		private readonly SQLiteAsyncConnection _connection;
//
//		public SQLiteClient ()
//		{
//			_connection = DependencyService.Get<ISQLite> ().GetConnection ();
//			CreateDatabaseAsync ();
//		}
//
//		public async Task CreateDatabaseAsync ()
//		{
//			using (await Mutex.LockAsync ().ConfigureAwait (false)) {
//				await _connection.CreateTableAsync<School> ().ConfigureAwait (false);
//			}
//		}
//
//		public async Task<List<School>> GetConferencesAsync ()
//		{
//			List<Conference> conferences = new List<Conference> ();
//			using (await Mutex.LockAsync ().ConfigureAwait (false)) {
//				conferences = await _connection.Table<Conference> ().ToListAsync ().ConfigureAwait (false);
//			}
//
//			return conferences;
//		}
//
//		public async Task Save (Conference conference)
//		{
//			using (await Mutex.LockAsync ().ConfigureAwait (false)) {
//				// Because our conference model is being mapped from the dto,
//				// we need to check the database by name, not id
//				var existingConference = await _connection.Table<Conference> ()
//					.Where (x => x.Slug == conference.Slug)
//					.FirstOrDefaultAsync ();
//
//				if (existingConference == null) {
//					await _connection.InsertAsync (conference).ConfigureAwait (false);
//				} else {
//					conference.Id = existingConference.Id;
//					await _connection.UpdateAsync (conference).ConfigureAwait (false);
//				}
//			}
//		}
//
//		public async Task SaveAll (IEnumerable<Conference> conferences)
//		{
//			foreach (var conference in conferences) {
//				await Save (conference);
//			}
//		}
//	}
//
//}
//
