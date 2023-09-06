﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstarct
{
    public interface ICommentService: IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
    }
}
