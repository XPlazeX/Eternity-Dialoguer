using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternity_Dialoger.Models
{
    public class DialogueObject
    {
        private bool _isHero;
        private int _characterID;
        private int _voiceID;
        private int _durationID;
        private string _text;

        public bool IsHero
        {
            get { return _isHero; }
            set { _isHero = value; }
        }

        public int CharacterID
        {
            get { return _characterID; }
            set { _characterID = value; }
        }

        public int VoiceID
        {
            get { return _voiceID; }
            set { _voiceID = value; }
        }

        public int DurationID
        {
            get { return _durationID; }
            set { _durationID = value; }
        }      

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }

    public class CharacterType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class VoiceType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class DurationType
    {
        public int ID { get; set; }
        public int Time { get; set; }
    }

}
