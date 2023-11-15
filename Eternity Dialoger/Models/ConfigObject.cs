using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternity_Dialoger.Models
{
    public class ConfigObject
    {
        public int CharacterID { get; private set; }
        private string nameInProgramm;

        public string NameInProgramm
        {
            get { return nameInProgramm; }
            set { nameInProgramm = value; }
        }

        private bool isHero;

        public bool IsHero
        {
            get { return isHero; }
            set { isHero = value; }
        }

        private int _bindedVoiceID;

        public int BindedVoiceID
        {
            get { return _bindedVoiceID; }
            set { _bindedVoiceID = value; }
        }

        public ConfigObject (int id)
        {
            CharacterID = id;
        }

    }
}
