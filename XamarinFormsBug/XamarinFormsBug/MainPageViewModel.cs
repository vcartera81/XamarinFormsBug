using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinFormsBug.Annotations;

namespace XamarinFormsBug
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SampleCellsGroup> _groups;

        public MainPageViewModel()
        {
            _groups = new ObservableCollection<SampleCellsGroup>
            {
                new SampleCellsGroup(new List<SampleCellModel>
                {
                    new SampleCellModel
                    {
                        Amount = 8.45,
                        Category = "Food & Drinks",
                        Comment = "This is a good one",
                        Title = "Pizza",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 4.12,
                        Category = "Food & Drinks",
                        Comment = "Test",
                        Title = "Tram",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 123,
                        Category = "Other",
                        Comment = "Bicycle",
                        Title = "Goods",
                        UserInitials = "EC",
                        Currency = "USD"
                    },
                })
                {
                    Date = DateTime.Now,
                    DayBalance = 8.45 + 4.12 + 123
                },
                new SampleCellsGroup(new List<SampleCellModel>
                {
                    new SampleCellModel
                    {
                        Amount = 8.45,
                        Category = "Food & Drinks",
                        Comment = "This is a good one",
                        Title = "Pizza",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 4.12,
                        Category = "Food & Drinks",
                        Comment = "Providing a very long comment to see how it will break the layout of the collection view",
                        Title = "Tram",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 123,
                        Category = "Other",
                        Comment = "Bicycle",
                        Title = "This is kind of a long title to see how it breaks on iOS",
                        UserInitials = "EC",
                        Currency = "USD"
                    },
                })
                {
                    Date = DateTime.Now,
                    DayBalance = 8.45 + 4.12 + 123
                },
                new SampleCellsGroup(new List<SampleCellModel>
                {
                    new SampleCellModel
                    {
                        Amount = 8.45,
                        Category = "Food & Drinks",
                        Comment = "This is a good one",
                        Title = "Pizza",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 4.12,
                        Category = "Food & Drinks",
                        Comment = "Providing a very long comment to see how it will break the layout of the collection view",
                        Title = "Tram",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 123,
                        Category = "Other",
                        Comment = "Bicycle",
                        Title = "Goods",
                        UserInitials = "EC",
                        Currency = "USD"
                    },
                })
                {
                    Date = DateTime.Now,
                    DayBalance = 8.45 + 4.12 + 123
                },
                new SampleCellsGroup(new List<SampleCellModel>
                {
                    new SampleCellModel
                    {
                        Amount = 8.45,
                        Category = "Food & Drinks",
                        Comment = "This is a good one",
                        Title = "Pizza",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 4.12,
                        Category = "Food & Drinks",
                        Comment = "Providing a very long comment to see how it will break the layout of the collection view",
                        Title = "Tram",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 123,
                        Category = "Other",
                        Comment = "Bicycle",
                        Title = "Goods",
                        UserInitials = "EC",
                        Currency = "USD"
                    },
                })
                {
                    Date = DateTime.Now,
                    DayBalance = 8.45 + 4.12 + 123
                },
                new SampleCellsGroup(new List<SampleCellModel>
                {
                    new SampleCellModel
                    {
                        Amount = 8.45,
                        Category = "Food & Drinks",
                        Comment = "This is a good one",
                        Title = "Pizza",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 4.12,
                        Category = "Food & Drinks",
                        Comment = "Providing a very long comment to see how it will break the layout of the collection view",
                        Title = "Tram",
                        UserInitials = "VC",
                        Currency = "CHF"
                    },
                    new SampleCellModel
                    {
                        Amount = 123,
                        Category = "Other",
                        Comment = "Bicycle",
                        Title = "Goods",
                        UserInitials = "EC",
                        Currency = "USD"
                    },
                })
                {
                    Date = DateTime.Now,
                    DayBalance = 8.45 + 4.12 + 123
                }
            };
        }

        public ObservableCollection<SampleCellsGroup> Groups
        {
            get => _groups;
            set
            {
                _groups = value;
                OnPropertyChanged(nameof(Groups));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
