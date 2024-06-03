using Characters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace MagicDestroyers
{
  public static class PlayersInfo
  {
    #region Methods
    static PlayersInfo()
    {
      PlayersInfoDirectoryPath = @"Info\";
      PlayersInfoFileName = "PlayersInfo.txt";
      PlayersInfoDir = new DirectoryInfo(PlayersInfoDirectoryPath);
      PlayersInfoFile = new FileInfo(PlayersInfoDirectoryPath + PlayersInfoFileName);
      Fullinfo = new List<string[]>();
    }

    public static void Initialize(List<Character> characters)
    {
      if (!PlayersInfoDir.Exists)
      {
        PlayersInfoDir.Create();
      }

      if (!PlayersInfoFile.Exists)
      {
        PlayersInfoFile.Create().Close();

        using (StreamWriter sw = PlayersInfoFile.CreateText())
        {
          foreach (Character character in characters)
          {
            sw.WriteLine($"{character.Name},{character.Faction},{character.Level}");
          }
        }
      }

      using (StreamReader sr = PlayersInfoFile.OpenText())
      {
        string line = string.Empty;

        while ((line = sr.ReadLine()) != null)
        {
          fullinfo.Add(line.Split(','));
        }
      }

      for (int i = 0; i < characters.Count; i++)
      {
        for (int j = 0; j < characters.Count; j++)
        {
          if (characters[i].Name == fullinfo[j][0])
          {
            characters[i].Level = Convert.ToInt32(fullinfo[j][2]);
          }
        }
      }
    }

    #region Methods

    public static void Save(List<Character> characters)
    {
      using (StreamWriter sw = PlayersInfoFile.CreateText())
      {
        foreach (var character in characters)
        {
          sw.WriteLine(string.Join(",", $"{character.Name},{character.Faction},{character.Level}"));
        }
      }
    }

    public static void UpdateFullInfo()
    {
      throw new NotImplementedException();
    }

    public static void RetrieveFullInfo()
    {
      throw new NotImplementedException();
    }

    public static void PrintFullInfo()
    {
      foreach (string[] character in Fullinfo)
      {
        Console.WriteLine($"Name: {character[0]}, , Level: {character[2]}");
      }
    }

    public static void EraseFullInfo()
    {
      throw new NotImplementedException();
    }

    public static void UpdateScores()
    {
      throw new NotImplementedException();
    }

    public static void RetrieveScores()
    {
      throw new NotImplementedException();
    }

    public static void PrintScores()
    {
      throw new NotImplementedException();
    }

    public static void EraseScores()
    {
      throw new NotImplementedException();
    }

    public static void UpdateLevels()
    {
      throw new NotImplementedException();
    }

    public static void RetrieveLevels()
    {
      throw new NotImplementedException();
    }

    public static void PrintLevels()
    {
      throw new NotImplementedException();
    }

    public static void EraseLevels()
    {
      throw new NotImplementedException();
    }
    #endregion

    #region Properties
    public static DirectoryInfo PlayersInfoDir
    {
      get => playersInfoDir;
      private set => playersInfoDir = value;
    }
    public static FileInfo PlayersInfoFile
    {
      get => playersInfoFile;
      set => playersInfoFile = value;
    }

    #endregion

    public static string PlayersInfoFileName
    {
      get => playersInfoFileName;
      private set => playersInfoFileName = value;
    }
    public static string PlayersInfoDirectoryPath
    {
      get => playersInfoDirectoryPath;
      private set => playersInfoDirectoryPath = value;
    }
    public static List<string[]> Fullinfo
    {
      get => fullinfo;
      set => fullinfo = value;
    }

    public static int[] Scores { get => scores; set => scores = value; }
    public static int[] Levels { get => levels; set => levels = value; }
    #endregion

    #region Fields
    private static DirectoryInfo playersInfoDir;
    private static FileInfo playersInfoFile;
    private static string playersInfoFileName;
    private static string playersInfoDirectoryPath;
    private static List<string[]> fullinfo;

    private static int[] scores;
    private static int[] levels;
    #endregion
  }
}
