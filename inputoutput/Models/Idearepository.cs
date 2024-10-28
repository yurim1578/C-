using inputoutput.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inputoutput.Models
{
    public class Idearepository : IIdeaRepository
    {
        private readonly ApplicationDbContext _context;
        public Idearepository(ApplicationDbContext context)
        {
                this._context = context;
        }
        public async Task<Idea> AddIdea(Idea idea)//입력
        {
            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();
            return idea;
        }

        public Task<List<Idea>> GetIdeas()//전체 출력
        {
            return _context.Ideas.ToListAsync(); 
        }
    }
}
