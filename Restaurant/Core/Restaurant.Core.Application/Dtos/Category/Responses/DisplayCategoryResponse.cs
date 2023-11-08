using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Dtos.Category.Responses
{
    public class DisplayCategoryResponse : BaseDto
    {

        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
