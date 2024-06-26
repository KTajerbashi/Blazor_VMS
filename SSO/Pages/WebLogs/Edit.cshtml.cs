﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.WebLogs
{
    public class EditModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public EditModel(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [BindProperty]
        public BlogDTO BlogDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogdto =  _blogRepository.Read(id.Value).Data;
            if (blogdto == null)
            {
                return NotFound();
            }
            BlogDTO = blogdto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            BlogDTO.CurrentUser = User;
            var result =_blogRepository.Update(BlogDTO);
            if (result.Success)
            {
                return RedirectToPage("./Index");

            }
            return new ChallengeResult();
        }

        private bool BlogDTOExists(long id)
        {
            return _blogRepository.Exist(id).Data;
        }
    }
}
