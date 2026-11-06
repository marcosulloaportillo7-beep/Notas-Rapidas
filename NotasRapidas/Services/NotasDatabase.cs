using NotasRapidas.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasRapidas.Services
{
    public class NotasDatabase
    {
        SQLiteAsyncConnection? db;

        async Task Init()
        {
            if (db != null)
                return;

            var path = Path.Combine(FileSystem.AppDataDirectory, "notas.db3");

            db = new SQLiteAsyncConnection(path);

            await db.CreateTableAsync<Nota>();
            await db.CreateTableAsync<Historial>();
        }

        public async Task<List<Nota>> GetNotasAsync()
        {
            await Init();
            return await db!.Table<Nota>().ToListAsync();
        }

        public async Task<int> SaveNotaAsync(Nota nota)
        {
            await Init();

            if (nota.Id != 0)
                return await db!.UpdateAsync(nota);

            return await db!.InsertAsync(nota);
        }

        public async Task<int> DeleteNotaAsync(Nota nota)
        {
            await Init();
            return await db!.DeleteAsync(nota);
        }

        public async Task<List<Historial>> GetHistorialAsync()
        {
            await Init();
            return await db!.Table<Historial>()
                .OrderByDescending(x => x.Fecha)
                .ToListAsync();
        }

        public async Task AddHistorialAsync(string accion)
        {
            await Init();

            await db!.InsertAsync(new Historial
            {
                Accion = accion,
                Fecha = DateTime.Now
            });
        }
    }
}