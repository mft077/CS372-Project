using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Each round have a sries of question
Stores the correct answer
Each round holds a number of question*/
[System.Serializable]
public class RoundData
{
    public string name;
    public int pointsAddedForCorrectAnswer;
    public QuestionData[] questions;
}
