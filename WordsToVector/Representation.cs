namespace WordsToVector
{
    public class Representation
    {
        private string word;
        private float[] vector;

        public Representation(string word, float[] vector)
        {
            this.word = word;
            this.vector = vector;
        }
    }
}