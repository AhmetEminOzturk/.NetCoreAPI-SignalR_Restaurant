using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Dtos.Category
{
    public class GenericCategoryDto : BaseDto
    {

        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
