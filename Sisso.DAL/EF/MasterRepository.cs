using System;
using System.Collections.Generic;
using System.Text;

namespace Sisso.DAL
{
    public abstract class MasterRepository
    {
        private SissoContext _context;

        public MasterRepository()
        {
            if (_context == null)
                _context = new SissoContext();
        }

        protected SissoContext Context
        {
            get { return _context; }
        }

    }
}
