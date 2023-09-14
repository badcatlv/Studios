namespace FunWithQuizes
{
    public class CheckBoxChoice : Question
    {
        public List<string> CollectedAnswers { get; set; }
        public List<string> UserChoices { get; set; }

        public CheckBoxChoice(string theActualQuestion, List<string> collectedAnswers, List<string> userChoices) : base(theActualQuestion)
        {
            CollectedAnswers = collectedAnswers;
            UserChoices = userChoices;
        }
    }
}
