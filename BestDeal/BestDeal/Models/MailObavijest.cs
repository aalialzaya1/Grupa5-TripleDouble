﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //Konkretni decorator pattern
    public class MailObavijest:Obavijest
    {
        //ne znam treba li ovaj konstruktor bas, ali neka ga da je jednostavnije
        public MailObavijest(string tekstObavijesti) : base(tekstObavijesti)
        {
        }

        new void posaljiObavijest (string obavijest)
        {
            base.posaljiObavijest(obavijest);
            //nesto specificno za mail
        }
    }
}
