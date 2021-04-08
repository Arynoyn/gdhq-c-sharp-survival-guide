using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    [SerializeField] private int _numberOfQuizGrades = 5;
    [SerializeField] private float _minQuizGrade = 0.0f;
    [SerializeField] private float _maxQuizGrade = 100.0f;
    
    private float[] _quizGrades;
    
    // Start is called before the first frame update
    void Start()
    {
        InitializeArray();
        PopulateRandomGrades();
        var gradesTotal = TotalGrades();
        float averageGrade = CalculateAverage(gradesTotal);
        Debug.Log($"The quiz grades are:  [{ListQuizGrades()}]");
        Debug.Log($"The average of these grades is {averageGrade:F2}");
    }

    private string ListQuizGrades()
    {
        string quizGradesString = string.Empty;
        for (int i = 0; i < _quizGrades.Length; i++)
        {
            quizGradesString += _quizGrades[i].ToString("F2");
            if (i < _quizGrades.Length - 1)
            {
                quizGradesString += ", ";
            }
        }

        return quizGradesString;
    }

    private float CalculateAverage(float gradesTotal)
    {
        return gradesTotal / _quizGrades.Length;
    }

    private float TotalGrades()
    {
        float gradesTotal = 0.0f;
        for (int i = 0; i < _quizGrades.Length; i++)
        {
            gradesTotal += _quizGrades[i];
        }

        return gradesTotal;
    }

    private void PopulateRandomGrades()
    {
        for (int i = 0; i < _quizGrades.Length; i++)
        {
            _quizGrades[i] = Random.Range(_minQuizGrade, _maxQuizGrade);
        }
    }

    private void InitializeArray()
    {
        _quizGrades = new float[_numberOfQuizGrades];
    }
}
