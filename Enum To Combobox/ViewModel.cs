﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Enum_To_Combobox
{
    public sealed class ViewModel : INotifyPropertyChanged
    {
        private ImageFormat imageFormat = ImageFormat.JPG;

        public ImageFormat Format
        {
            get => imageFormat;
            set
            {
                if (imageFormat == value)
                {
                    return;
                }

                imageFormat = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
