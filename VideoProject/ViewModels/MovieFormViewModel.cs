using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoProject.Models;

namespace VideoProject.ViewModels
{
	public class MovieFormViewModel
	{
		public IEnumerable<Genre> Genres { get; set; }

		public int? Id { get; set; }

		public string Name { get; set; }

		public Genre Genre { get; set; }

		[Display(Name = "Genre")]
		public byte GenreId { get; set; }

		[Required]
		[Display(Name = "Release Date")]
		public DateTime? ReleaseDate { get; set; }

		[Required]
		public DateTime? DateAdded { get; set; }

		[Required]
		[Range(1, 20)]
		[Display(Name = "Number in Stock")]
		public int? InStock { get; set; }

		public string Title
		{
			get
			{
				return null != Id && Id != 0 ? "Edit Movie" : "New Movie";
			}
		}
		public MovieFormViewModel()
		{
			Id = 0;
		}

		public MovieFormViewModel(Movie movie)
		{
			Id = movie.Id;
			Name = movie.Name;
			ReleaseDate = movie.ReleaseDate;
			InStock = movie.InStock;
			GenreId = movie.GenreId;
		}
	}
}