﻿using Characters;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MagicDestroyers
{
  public static class PlayersInfo
  {
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

    public static void Save(Character character)
    {
      CharacterFileName = string.Concat(character.Name, ".txt");
      FileInfo characterFile = new FileInfo(Path.Combine(PlayersInfoDirectoryPath, CharacterFileName));
      string json = JsonConvert.SerializeObject(character);

      if (!characterFile.Exists)
      {
        characterFile.Create().Close();
        using (StreamWriter sw = characterFile.CreateText())
        {
          sw.WriteLine(json);
        }
      }
    }

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

    public static Character LoadWarrior(string characterName)
    {
      //CharacterFileName = string.Concat(characterName, ".txt");
      //FileInfo characterFile = new FileInfo(Path.Combine(PlayersInfoDirectoryPath, CharacterFileName));

      //if (characterFile.Exists)
      //{        
      //  using (StreamReader sr = new StreamReader(characterFile.FullName))
      //  {
      //    string line = sr.ReadToEnd();
      //    string jsonString = JsonConvert.SerializeObject(line);

      //    Character character = JsonConvert.DeserializeObject<Warrior>(jsonString);

      //    return character;
      //  }
      //}
      //else return null;

      CharacterFileName = string.Concat(characterName, ".json");
      FileInfo characterFile = new FileInfo(Path.Combine(PlayersInfoDirectoryPath, CharacterFileName));

      JObject o1 = JObject.Parse(File.ReadAllText(characterFile.FullName));
      Warrior warrior = o1.ToObject<Warrior>();

      // read JSON directly from a file
      using (StreamReader file = File.OpenText(characterFile.FullName))

      using (JsonTextReader reader = new JsonTextReader(file))
      {
        JObject o2 = (JObject)JToken.ReadFrom(reader);
      }

      //if (characterFile.Exists)
      //{
      //  using (StreamReader sr = new StreamReader(characterFile.FullName))
      //  {
      //    string line = sr.ReadToEnd();
      //    string jsonString = JsonConvert.SerializeObject(line);

      //    Character character = JsonConvert.DeserializeObject<Warrior>(jsonString);

      //    return character;
      //  }
      //}
      return null;
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
    public static string CharacterFileName
    {
      get => characterFileName;
      set => characterFileName = value;
    }

    public static int[] Scores { get => scores; set => scores = value; }
    public static int[] Levels { get => levels; set => levels = value; }
    #endregion

    #region Fields
    private static DirectoryInfo playersInfoDir;
    private static FileInfo playersInfoFile;
    private static string playersInfoFileName;
    private static string playersInfoDirectoryPath;
    private static string characterFileName;
    private static List<string[]> fullinfo;

    private static int[] scores;
    private static int[] levels;
    #endregion
  }
}
