using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfBinding
{
    public class ViewModel: INotifyPropertyChanged
    {
        public ListCollectionView CollectionView { get; set; }

        public List<Soup> Soups { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModel()
        {
            this.Soups=  new List<Soup>
        {
            new Soup {Brand="Heinz", Type="Tomato", Price=(decimal) 0.69},
            new Soup {Brand="Heinz", Type="Pea & Ham", Price=(decimal) 0.69},
            new Soup {Brand="Crossee & Blackwell", Type="Tomato", Price=(decimal) 0.79},
            new Soup {Brand="Crossee & Blackwell", Type="Pea & Ham", Price=(decimal) 0.79},
            new Soup {Brand="Cambells", Type="Tomato", Price=(decimal) 0.99 },
            new Soup {Brand="Cambells", Type="Pea & Ham", Price=(decimal) 0.99},
            new Soup {Brand="Baxters", Type="Scottish Tomato", Price=(decimal) 1.79},
            new Soup {Brand="Baxters", Type="Royal Game", Price=(decimal) 2.79},
        };

            this.CollectionView = new ListCollectionView(Soups);
            this.CollectionView.GroupDescriptions.Add(new PropertyGroupDescription("Brand"));
            
        }

    }
}
