namespace MadLibs.Models
{
    public class MadLibsVariables
    {
        private string _personOne;
        private string _personTwo;
        private string _animal;
        private string _exclamation;
        private string _verb;
        private string _noun;

        public string GetPersonOne()
        {
            return _personOne;
        }
        public void SetPersonOne(string newPersonOne)
        {
            _personOne = newPersonOne;
        }
        public string GetPersonTwo()
        {
            return _personTwo;
        }
        public void SetPersonTwo(string newPersonTwo)
        {
            _personTwo = newPersonTwo;
        }
        public string GetAnimal()
        {
            return _animal;
        }
        public void SetAnimal(string newAnimal)
        {
            _animal = newAnimal;
        }
        public string GetExclamation()
        {
            return _exclamation;
        }
        public void SetExclamation(string newExclamation)
        {
            _exclamation = newExclamation;
        }
        public string GetVerb()
        {
            return _verb;
        }
        public void SetVerb(string newVerb)
        {
            _verb = newVerb;
        }
        public string GetNoun()
        {
            return _noun;
        }
        public void SetNoun(string newNoun)
        {
            _noun = newNoun;
        }
    }
}