using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admeli.Componentes
{
    public class Paginacion
    {
        public int currentPage { get; set; }
        public int pageCount { get; set; }
        public int pageInterval { get; set; }
        public int itemsCount { get; set; }
        public int itemFrom { get; set; }
        public int speed { get; set; }

        public Paginacion(int currentPage, int steep)
        {
            this.currentPage = currentPage;
            this.speed = steep;
            itemFrom = 1;
            reload();
        }
        public void reload()
        {
            pageCount = Convert.ToInt32(Math.Ceiling(itemsCount / (decimal)speed));
        }

        public void nextPage()
        {
            this.currentPage += 1;
            this.itemFrom += this.speed;
            this.reload();
        }

        public void previousPage()
        {
            this.currentPage -= 1;
            this.itemFrom -= this.speed;
            this.reload();
        }

        public void reloadPage(int currentPage)
        {
            this.currentPage = currentPage;
            // this.itemFrom = this.speed;
            this.reload();
        }

        public void firstPage()
        {
            this.currentPage = 1;
            this.itemFrom = 1;
            this.reload();
        }

        public void lastPage()
        {
            this.currentPage = pageCount;
            // this.itemFrom = itemsCount - steep;
            this.reload();
        }
    }
}
