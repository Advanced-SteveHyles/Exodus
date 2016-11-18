using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork;

//https://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

namespace Xunit
{
    public class BuildReal
    {
        public DataContext1 DataContext { get; set; }

        public BuildReal()
        {
            this.DataContext = new EntityFrameWork.DataContext1();
        }

        [Fact]
        public void BuildMe()
        {
            
           Assert.True(true); 
        }

    }
}
