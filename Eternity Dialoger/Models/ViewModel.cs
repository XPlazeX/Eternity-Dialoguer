using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternity_Dialoger.Models
{
    public class ViewModel
    {
        const int min_message_symbols_for_shortest_voice = 15;
        const int letters_per_voice_duration = 5;

        public ObservableCollection<DialogueObject> DialogueObjects { get; private set; }
        public ObservableCollection<CharacterType> CharacterTypes { get; private set; }
        public ObservableCollection<VoiceType> VoiceTypes { get; private set; }
        public ObservableCollection<DurationType> DurationTypes { get; private set; }

        public ObservableCollection<ConfigObject> ConfigObjects { get; private set; }

        public ViewModel()
        {
            DialogueObjects = new ObservableCollection<DialogueObject>()
            {
                new DialogueObject() {CharacterID = 0, Text="Приветствую тебя, создатель!" }
            };

            Load();
        }

        public void Load()
        {
            LoadDefaultVoices();
            LoadDefaultDurations();
            LoadConfig();

            CharacterTypes = new ObservableCollection<CharacterType>();

            for (int i = 0; i < ConfigObjects.Count; i++)
            {
                CharacterTypes.Add(new CharacterType() { ID = i, Name = ConfigObjects[i].NameInProgramm });
            }
        }

        public void LoadConfig()
        {
            ConfigObjects = new ObservableCollection<ConfigObject>(FileHandler.LoadConfigFile());

            if (ConfigObjects.Count < 1)
            {
                InitNewConfig();
            }
        }

        public void InitNewConfig()
        {
            List<ConfigObject> NewConfigList = new List<ConfigObject>()
            {
                new ConfigObject(0) {NameInProgramm = "№ Таро", IsHero = true, BindedVoiceID = 0},
                new ConfigObject(1) {NameInProgramm = "№ Таро ENNEAD", IsHero = true, BindedVoiceID = 0},
                new ConfigObject(2) {NameInProgramm = "№ Таро Утомлённый", IsHero = true, BindedVoiceID = 0},
                new ConfigObject(3) {NameInProgramm = "№ Таро ENNEAD Утомл", IsHero = true, BindedVoiceID = 0},
                new ConfigObject(4) {NameInProgramm = "№ Таро в шлеме", IsHero = true, BindedVoiceID = 1},
                new ConfigObject(5) {NameInProgramm = "Ъ Шум", IsHero = false, BindedVoiceID = 11},
                new ConfigObject(6) {NameInProgramm = "Ъ Бортовой ИИ", IsHero = false, BindedVoiceID = 8},
                new ConfigObject(7) {NameInProgramm = "Ъ И.Р.И.С.", IsHero = false, BindedVoiceID = 9},
                new ConfigObject(8) {NameInProgramm = "Ъ Зевс", IsHero = false, BindedVoiceID = 14},
                new ConfigObject(9) {NameInProgramm = "Ъ Таро?", IsHero = false, BindedVoiceID = 3},
                new ConfigObject(10) {NameInProgramm = "Ъ Слабая частота", IsHero = false, BindedVoiceID = 14},
                new ConfigObject(11) {NameInProgramm = "Ъ Гипно-частота", IsHero = false, BindedVoiceID = 12},
                new ConfigObject(12) {NameInProgramm = "Ъ Высокая частота", IsHero = false, BindedVoiceID = 13}
            };

            FileHandler.SaveConfigFile(NewConfigList);

            ConfigObjects = new ObservableCollection<ConfigObject>(FileHandler.LoadConfigFile());
        }

        public void LoadDefaultVoices()
        {
            VoiceTypes = new ObservableCollection<VoiceType>()
            {
                new VoiceType() {ID = 0, Name="Человек обычный" },
                new VoiceType() {ID = 1, Name="Человек другой" },
                new VoiceType() {ID = 2, Name="Человек высокий" },
                new VoiceType() {ID = 3, Name="Человек крутой" },
                new VoiceType() {ID = 4, Name="Женский обычный" },
                new VoiceType() {ID = 5, Name="Женский высокий" },
                new VoiceType() {ID = 6, Name="Женский крутой" },
                new VoiceType() {ID = 7, Name="Женский манящий" },
                new VoiceType() {ID = 8, Name="Робот обычный" },
                new VoiceType() {ID = 9, Name="Робот бас" },
                new VoiceType() {ID = 10, Name="Робот угроза" },
                new VoiceType() {ID = 11, Name="Шум" },
                new VoiceType() {ID = 12, Name="Сигнал средний" },
                new VoiceType() {ID = 13, Name="Сигнал высокий" },
                new VoiceType() {ID = 14, Name="Сигнал глухой" },
                new VoiceType() {ID = 15, Name="Заражённый" },
                new VoiceType() {ID = 16, Name="Монстр средний" },
                new VoiceType() {ID = 17, Name="Монстр высший" },
            };
        }

        public void LoadDefaultDurations()
        {
            DurationTypes = new ObservableCollection<DurationType>()
            {
                new DurationType() {ID = 0, Time=3 },
                new DurationType() {ID = 1, Time=5 },
                new DurationType() {ID = 2, Time=8 },
                new DurationType() {ID = 3, Time=10 },
                new DurationType() {ID = 4, Time=13 },
                new DurationType() {ID = 5, Time=16 },
                new DurationType() {ID = 6, Time=19 },
                new DurationType() {ID = 7, Time=23 }
            };
        }

        public void SetData(List<DialogueObject> data)
        {
            DialogueObjects.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                DialogueObjects.Add(data[i]);
            }
        }

        public List<DialogueObject> GetData()
        {
            return new List<DialogueObject>(DialogueObjects);
        }

        public void AddDialogeObject()
        {
            DialogueObjects.Add(new DialogueObject());
        }

        public void AddConfigObject()
        {
            ConfigObjects.Add(new ConfigObject(ConfigObjects.Count) {NameInProgramm="--Имя--", BindedVoiceID=0});
        }

        public void RemoveDialogueObject()
        {
            DialogueObjects.RemoveAt(DialogueObjects.Count - 1);
        }

        public void AutoFields()
        {
            for (int i = 0; i < DialogueObjects.Count; i++)
            {
                DialogueObject d = DialogueObjects[i];
                int characterID = DialogueObjects[i].CharacterID;

                for (int j = 0; j < ConfigObjects.Count; j++)
                {
                    if (ConfigObjects[j].CharacterID == characterID)
                    {
                        DialogueObjects[i].IsHero = ConfigObjects[j].IsHero;
                        DialogueObjects[i].VoiceID = ConfigObjects[j].BindedVoiceID;

                        if (string.IsNullOrEmpty(DialogueObjects[i].Text))
                        {
                            DialogueObjects[i].DurationID = 0;
                            break;
                        }

                        int messageLen = DialogueObjects[i].Text.Length;
                        int voiceLen = 3;

                        int additiveLen = (int)Math.Ceiling((1f * messageLen - min_message_symbols_for_shortest_voice) / letters_per_voice_duration);

                        if (additiveLen > 0)
                            voiceLen += additiveLen;

                        int selectedDurationID = -1;
                        for (int l = 0; l < DurationTypes.Count; l++)
                        {
                            if (DurationTypes[l].Time <= voiceLen)
                                selectedDurationID++;
                            else
                                break;
                        }

                        DialogueObjects[i].DurationID = selectedDurationID;
                        break;
                    }
                }
            }

            
            //SetData(new List<DialogueObject>(DialogueObjects));
        }
    }
}
