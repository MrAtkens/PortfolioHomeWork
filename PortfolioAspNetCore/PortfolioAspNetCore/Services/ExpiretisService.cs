using Microsoft.EntityFrameworkCore;
using PortfolioAspNetCore.DataAcces;
using PortfolioAspNetCore.Models;
using PortfolioAspNetCore.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioAspNetCore.Services
{
    public class ExpiretisService
    {
        private readonly ExpiretisContext expiretisContext;
        public ExpiretisService(ExpiretisContext expiretisContext)
        {
            this.expiretisContext = expiretisContext;
        }

            public async Task<List<Expiretis>> GetExpiretis()
        {
            List<Expiretis> expiretis = await expiretisContext.Expiretis.ToListAsync();
            return expiretis;
        }
        public async Task<Expiretis> AddExpiretis(ExpiretisViewModel expiretisViewModel)
        {
            try
            {

                Expiretis expiretis = new Expiretis() { Id = Guid.NewGuid(), Article = expiretisViewModel.Article, DateOfExpiretis = expiretisViewModel.DateOfExpiretis, Description = expiretisViewModel.Description };
                expiretisContext.Expiretis.Add(expiretis);
                await expiretisContext.SaveChangesAsync();
                return expiretis;
            }
            catch (Exception ex)
            {
                Expiretis expiretis = new Expiretis() {};

                return expiretis;
            }
        }

        public async Task<Expiretis> DeleteExpiretis(Guid id)
        {
            try
            {
                Expiretis expiretis = await expiretisContext.Expiretis.FindAsync(id);
                expiretisContext.Expiretis.Remove(expiretis);
                await expiretisContext.SaveChangesAsync();
                return expiretis;
            }
            catch (Exception ex)
            {
                Expiretis expiretis = new Expiretis() { };
                return expiretis;
            }
        }

        public async Task<Expiretis> ExpiretisEdit(Expiretis expiretisEdit)
        {
            try
            {
                Expiretis expiretis = new Expiretis { Id = expiretisEdit.Id, Article = expiretisEdit.Article, DateOfExpiretis = expiretisEdit.DateOfExpiretis, Description = expiretisEdit.Description };
                expiretisContext.Entry(expiretis).State = EntityState.Modified;
                await expiretisContext.SaveChangesAsync();
                return expiretis;
            }
            catch (Exception ex)
            {
                Expiretis expiretis = new Expiretis() { };
                return expiretis;
            }
        }
    }
}
