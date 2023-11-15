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
        public ObservableCollection<DialogueObject> DialogueObjects { get; private set; }
        public ObservableCollection<CharacterType> CharacterTypes { get; private set; }
        public ObservableCollection<VoiceType> VoiceTypes { get; private set; }
        public ObservableCollection<DurationType> DurationTypes { get; private set; }

        public ViewModel()
        {
            DialogueObjects = new ObservableCollection<DialogueObject>()
            {
                new DialogueObject() {CharacterID = 1, Text="Приветствую тебя, создатель!" }
            };

            CharacterTypes = new ObservableCollection<CharacterType>()
            {
                new CharacterType() {ID = 0, Name="№ Таро" },
                new CharacterType() {ID = 1, Name="№ Таро ENNEAD" },
                new CharacterType() {ID = 2, Name="№ Таро Утомлённый" },
                new CharacterType() {ID = 3, Name="№ Таро ENNEAD Утомл" },
                new CharacterType() {ID = 4, Name="№ Таро в шлеме" },
                new CharacterType() {ID = 5, Name="Ъ Шум" },
                new CharacterType() {ID = 6, Name="Ъ Бортовой ИИ" },
                new CharacterType() {ID = 7, Name="Ъ И.Р.И.С." },
                new CharacterType() {ID = 8, Name="Ъ Зевс" },
                new CharacterType() {ID = 9, Name="Ъ Таро?" },
                new CharacterType() {ID = 10, Name="Ъ Слабая частота" },
                new CharacterType() {ID = 11, Name="Ъ Гипно-частота" },
                new CharacterType() {ID = 12, Name="Ъ Высокая частота" },
            };

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

        public void RemoveDialogueObject()
        {
            DialogueObjects.RemoveAt(DialogueObjects.Count - 1);
        }
    }
}
