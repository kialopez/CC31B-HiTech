using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _credit;
        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass 
        { 
            get 
            {
                return _characterClass;
            }
            set 
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int Hitpoints 
        { 
            get 
            {
                return _hitPoints;
            }
            set 
            {
                _hitPoints = value;
                OnPropertyChanged("Hitpoints");
            }
        }
        public int ExperiencePoints 
        { 
            get 
            {
                return _experiencePoints;
            }
            set 
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int Level 
        {  
            get 
            {
                return _level;
            }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Credit 
        { 
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
                OnPropertyChanged("Credit");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
