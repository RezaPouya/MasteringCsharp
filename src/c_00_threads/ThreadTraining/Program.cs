using ThreadTraining.Lessons;

public class Program
{

    private static void Main(string[] args)
    {
        //Run_Lesson_01();
        //Run_Lesson_02();
        //Run_Lesson_02();
        //Run_Lesson_03();
        //Run_Lesson_04();
        Run_Lesson_05();
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


    private static void Run_Lesson_03()
    {
        L_03_SyncIssue.Run();
    }

    private static void Run_Lesson_04()
    {
        L_04_LockExample.Run();
    }

    private static void Run_Lesson_05()
    {
        L_05_WhatIsLock.Run();
    }
}