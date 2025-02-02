﻿using System.ComponentModel.DataAnnotations;

namespace CoderWebsite.Models.Pages.Admin
{
    public class AddNewsModel
    {
        [Required(ErrorMessage = "Заголовок новости является обязательным.")]
        [MaxLength(255, ErrorMessage = "Длина заголовка не должна превышать 255 символов.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Новость должна содержать текст.")]
        public string? Text { get; set; }

        [MaxLength(255, ErrorMessage = "Длина заголовка SEO не должна превышать 255 символов.")]
        public string? SEOTitle { get; set; }

        public string? SEOKeywords { get; set; }

        public string? SEODescription { get; set; }
    }
}