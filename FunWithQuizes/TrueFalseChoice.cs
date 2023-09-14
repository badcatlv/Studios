namespace FunWithQuizes
{
    public class TrueFalseChoice : Question
    {
        public bool AnswerValue { get; set; }
        public TrueFalseChoice(string theActualQuestion, bool answerBool) : base(theActualQuestion)
        {
            AnswerValue = answerBool;
        }
    }
}
