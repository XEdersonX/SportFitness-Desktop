using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace sportFitness
{
    interface ICadastro
    {
        void insert();
        void update();
        void delete();
        DataTable select(string options = "");
    }
}
