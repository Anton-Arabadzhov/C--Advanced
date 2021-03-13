using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int minStats = 0;
        private const int maxStats = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name 
        {
            get => this.name;
            private set
            {
                Validator.ThrowIfStringIsNullOrWhiteSpace(value, GlobalConstants.InvalidNameErrorMessage);
                this.name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                Validator.ThrowIfStatsIsNotValid(value,
                    minStats,
                    maxStats,
                    $"{nameof(this.Endurance)} should be between {minStats} and {maxStats}.");
               this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                Validator.ThrowIfStatsIsNotValid(value,
                    minStats,
                    maxStats,
                    $"{nameof(this.Sprint)} should be between {minStats} and {maxStats}.");
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                Validator.ThrowIfStatsIsNotValid(value,
                    minStats,
                    maxStats,
                    $"{nameof(this.Dribble)} should be between {minStats} and {maxStats}.");
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                Validator.ThrowIfStatsIsNotValid(value,
                    minStats,
                    maxStats,
                    $"{nameof(this.Passing)} should be between {minStats} and {maxStats}.");
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                Validator.ThrowIfStatsIsNotValid(shooting,
                    minStats,
                    maxStats,
                    $"{nameof(this.Shooting)} should be between {minStats} and {maxStats}.");
                this.shooting = value;
            }
        }

        public double AverageSkillPoints
        {
            get 
            {
                return Math.Round((this.Endurance +
                    this.Sprint +
                    this.Dribble +
                    this.Passing +
                    this.Shooting) / 5.0);
            }
        }
        
            
        

    }
}
