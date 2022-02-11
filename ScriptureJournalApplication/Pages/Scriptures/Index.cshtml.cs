using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournalApplication.Data;
using ScriptureJournalApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptureJournalApplication.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournalApplication.Data.ScriptureJournalApplicationContext _context;

        public IndexModel(ScriptureJournalApplication.Data.ScriptureJournalApplicationContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        
        public string ScriptureBook { get; set; }

        public string SortBy { get; set; }




        //this is where i can add search strings
        public async Task OnGetAsync(string SortBy)
        {
            IQueryable<string> bookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;
            

            var scriptures = from m in _context.Scripture select m;

            

            

                if (!string.IsNullOrEmpty(SearchString))
                {
                
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString));
                }

                if (!string.IsNullOrEmpty(ScriptureBook))
                {
                ScriptureBook = ScriptureBook.Replace("&", " ");
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
                    
                }

            if (SortBy == "Book")
            {
                scriptures = scriptures.AsQueryable().OrderBy(scriptures => scriptures.Book);
            }

            if (SortBy == "Date")
            {
                scriptures = scriptures.AsQueryable().OrderByDescending(scriptures => scriptures.Date);
            }


            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
    
        }
    }
}
