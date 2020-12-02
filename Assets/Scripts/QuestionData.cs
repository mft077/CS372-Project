using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Holds information about questions. Each question holds number of answer
[System.Serializable]
public class QuestionData
{
    public string questionText;
    public AnswerData[] answers;
}
