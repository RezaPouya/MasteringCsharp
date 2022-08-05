using ThreadTraining.Lessons;

public class Program
{
    private static void Main(string[] args)
    {
        //Run_Lesson_01();
        //Run_Lesson_02();
        //Run_Lesson_02();
        //L_03_SyncIssue.Run();
        //L_04_LockExample.Run();
        //L_05_WhatIsLock.Run();
        L_05_DivideAnConcure.Run();
    }

    private static void Run_Lesson_00()
    {
        L_00_Thread lesson = new L_00_Thread();
        lesson.Run();
    }

    private static void Run_Lesson_01()
    {
        L_01_MultipleThread lesson = new L_01_MultipleThread();
        lesson.Run();
    }

    private static void Run_Lesson_02()
    {
        L_02_BG_FG_Worker lesson = new L_02_BG_FG_Worker();
        lesson.Run();
    }
}