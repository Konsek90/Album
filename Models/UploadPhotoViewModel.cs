using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Models
{
    public class UploadPhotoViewModel
    {
        public int WycieczkaId { get; set; }
        public IFormFile Photo { get; set; }
    }

    public class DeletePhotoViewModel
    {
        public int Idwycieczka { get; set; }
        public string PhotoName { get; set; }

    }
}
