﻿using Restaurant.Core.Application.Dtos.Contact;
using Restaurant.Core.Application.Dtos.Contact.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.ContactService
{
    public interface IContactService : IGenericService<Contact , GenericContactDto>
    {
        void TAdd(CreateContactRequest createContactRequest);
    }
}
