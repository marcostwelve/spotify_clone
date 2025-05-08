using Microsoft.EntityFrameworkCore;
using Modelos.Models;
using Repository.Context;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Service : IService
    {
        private readonly ApplicationDBContext _context;
        public Service(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Media>> GetAll()
        {
            return await _context.Medias.ToListAsync();
        }

        public async Task Insert(Media media)
        {
            if (media != null)
            {
                await _context.Medias.AddAsync(media);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(media), "Media cannot be null");
            }
        }

        public async Task Update(Media media)
        {
            if (media != null)
            {
                var existingMedia = await _context.Medias.FindAsync(media.Id);

                existingMedia.Titulo = media.Titulo;
                existingMedia.Descricao = media.Descricao;
                existingMedia.UrlImagem = media.UrlImagem;
                existingMedia.UrlMidia = media.UrlMidia;
                existingMedia.Visualizacoes = media.Visualizacoes;
                existingMedia.Categoria = media.Categoria;
                existingMedia.DataPublicacao = DateTime.Now;

                _context.Medias.Update(existingMedia);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(media), "Media cannot be null");
            }
        }

        public async Task Delete(int id)
        {
            var media = await _context.Medias.FindAsync(id);
            if (media != null)
            {
                _context.Medias.Remove(media);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Media with ID {id} not found");
            }
        }
    }
}
