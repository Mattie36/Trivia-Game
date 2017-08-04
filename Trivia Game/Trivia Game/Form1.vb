Public Class Form1
    Dim correct As Integer
    Dim score As Integer = 0
    Dim answered As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Q1.Click
        Q1.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "How many teams are in the National Football League?"
        Answer1.Text = "20"
        Answer2.Text = "32"
        Answer3.Text = "24"
        Answer4.Text = "30"
        correct = 2

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim userAnswer As Integer

        If Answer1.Checked Then
            userAnswer = 1
        ElseIf Answer2.Checked Then
            userAnswer = 2
        ElseIf Answer3.Checked Then
            userAnswer = 3
        ElseIf Answer4.Checked Then
            userAnswer = 4
        End If

        If userAnswer = correct Then
            MsgBox("Correct!")
            score = score + 1
            answered = answered + 1
        Else
            MsgBox("Incorrect")
            answered = answered + 1
        End If

        Score_l.Text = "Score: " & score
        QuestionsAnswered.Text = "Questions Answered: " & answered & "/20"

        Panel1.Enabled = False
        Panel2.Enabled = True
        Panel3.Enabled = True


    End Sub

    Private Sub Q2_Click(sender As Object, e As EventArgs) Handles Q2.Click
        Q2.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "What team has the most SuperBowl wins?"
        Answer1.Text = "New England Patriots"
        Answer2.Text = "Seattle Seahawks"
        Answer3.Text = "Pittsburgh Steelers"
        Answer4.Text = "Denver Broncos"
        correct = 3
    End Sub

    Private Sub Q3_Click(sender As Object, e As EventArgs) Handles Q3.Click
        Q3.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "Who is the starting quarterback for the Miami Dolphins?"
        Answer1.Text = "Ryan Tannehill"
        Answer2.Text = "Ben Rothlisburger"
        Answer3.Text = "Cam Newton"
        Answer4.Text = "Matt Moore"
        correct = 1
    End Sub

    Private Sub Q4_Click(sender As Object, e As EventArgs) Handles Q4.Click
        Q4.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "What teams were in Super Bowl 50?"
        Answer1.Text = "New England Patriots and Seattle Seahawks"
        Answer2.Text = "New England Patriots and Atlanta Falcons"
        Answer3.Text = "Seattle Seahawks and Denver Broncos"
        Answer4.Text = "Denver Broncos and Carolina Panthers"
        correct = 4
    End Sub

    Private Sub Q5_Click(sender As Object, e As EventArgs) Handles Q5.Click
        Q5.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "How many teams in the NFL have never won a Super Bowl?"
        Answer1.Text = "5"
        Answer2.Text = "15"
        Answer3.Text = "0"
        Answer4.Text = "13"
        correct = 4
    End Sub

    Private Sub Q6_Click(sender As Object, e As EventArgs) Handles Q6.Click
        Q6.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "What team's fans are called Cheeseheads?"
        Answer1.Text = "Tampa Bay Buccaneers"
        Answer2.Text = "Green Bay Packers"
        Answer3.Text = "San Diego Chargers"
        Answer4.Text = "Oakland Raiders"
        correct = 2
    End Sub

    Private Sub Q7_Click(sender As Object, e As EventArgs) Handles Q7.Click
        Q7.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "What team plays at Bank of America Stadium?"
        Answer1.Text = "Carolina Panthers"
        Answer2.Text = "New England Patriots"
        Answer3.Text = "Philadelphia Eagles"
        Answer4.Text = "Cleveland Browns"
        correct = 1
    End Sub

    Private Sub Q8_Click(sender As Object, e As EventArgs) Handles Q8.Click
        Q8.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "What is the New England Patriots most recent scandal?"
        Answer1.Text = "Spy-Gate"
        Answer2.Text = "Snowplow-Gate"
        Answer3.Text = "Deflate-Gate"
        Answer4.Text = "Deception-Gate"
        correct = 3
    End Sub

    Private Sub Q9_Click(sender As Object, e As EventArgs) Handles Q9.Click
        Q9.Enabled = False
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Enabled = False
        Question.Text = "What year was the first Super Bowl played?"
        Answer1.Text = "1963"
        Answer2.Text = "1961"
        Answer3.Text = "1965"
        Answer4.Text = "1967"
        correct = 4
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Enabled = False
    End Sub
End Class