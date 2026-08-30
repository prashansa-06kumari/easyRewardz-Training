using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class IPLMatch
{
    public int match_id { get; set; }

    public string team1 { get; set; }

    public string team2 { get; set; }

    public Dictionary<string, int> score { get; set; }

    public string winner { get; set; }

    public string player_of_match { get; set; }
}

class IPLCensorshipAnalyzer
{
    public static void Run()
    {
        Console.WriteLine("===== IPL CENSORSHIP ANALYZER =====");

        ProcessJson();

        ProcessCsv();

        Console.WriteLine(
            "Censorship completed successfully."
        );
    }

    // ==========================================
    // JSON PROCESSING
    // ==========================================

    static void ProcessJson()
    {
        string inputFile = "ipl_matches.json";
        string outputFile = "censored_ipl_matches.json";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine(
                "JSON input file not found."
            );

            return;
        }

        string json =
            File.ReadAllText(inputFile);

        List<IPLMatch> matches =
            JsonConvert.DeserializeObject<List<IPLMatch>>(
                json
            );

        foreach (IPLMatch match in matches)
        {
            Dictionary<string, int> newScore =
                new Dictionary<string, int>();

            string maskedTeam1 =
                MaskTeamName(match.team1);

            string maskedTeam2 =
                MaskTeamName(match.team2);

            foreach (var score in match.score)
            {
                string maskedTeam =
                    MaskTeamName(score.Key);

                newScore[maskedTeam] =
                    score.Value;
            }

            match.team1 = maskedTeam1;
            match.team2 = maskedTeam2;

            match.winner =
                MaskTeamName(match.winner);

            match.player_of_match =
                "REDACTED";

            match.score = newScore;
        }

        string outputJson =
            JsonConvert.SerializeObject(
                matches,
                Formatting.Indented
            );

        File.WriteAllText(
            outputFile,
            outputJson
        );

        Console.WriteLine(
            "Censored JSON created."
        );
    }

    // ==========================================
    // CSV PROCESSING
    // ==========================================

    static void ProcessCsv()
    {
        string inputFile = "ipl_matches.csv";
        string outputFile = "censored_ipl_matches.csv";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine(
                "CSV input file not found."
            );

            return;
        }

        string[] lines =
            File.ReadAllLines(inputFile);

        List<string> output =
            new List<string>();

        // Header
        output.Add(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data =
                lines[i].Split(',');

            if (data.Length < 7)
            {
                Console.WriteLine(
                    $"Invalid CSV row: {lines[i]}"
                );

                continue;
            }

            string matchId = data[0];

            string team1 =
                MaskTeamName(data[1]);

            string team2 =
                MaskTeamName(data[2]);

            string scoreTeam1 =
                data[3];

            string scoreTeam2 =
                data[4];

            string winner =
                MaskTeamName(data[5]);

            string playerOfMatch =
                "REDACTED";

            string newRow =
                $"{matchId}," +
                $"{team1}," +
                $"{team2}," +
                $"{scoreTeam1}," +
                $"{scoreTeam2}," +
                $"{winner}," +
                $"{playerOfMatch}";

            output.Add(newRow);
        }

        File.WriteAllLines(
            outputFile,
            output
        );

        Console.WriteLine(
            "Censored CSV created."
        );
    }

    // ==========================================
    // TEAM MASKING
    // ==========================================

    static string MaskTeamName(string teamName)
    {
        if (string.IsNullOrWhiteSpace(teamName))
        {
            return teamName;
        }

        string[] words =
            teamName.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

        if (words.Length == 1)
        {
            return "***";
        }

        if (words.Length == 2)
        {
            return words[0] + " ***";
        }

        // Example:
        // Royal Challengers Bangalore
        //
        // Royal *** Bangalore

        words[1] = "***";

        return string.Join(" ", words);
    }
}