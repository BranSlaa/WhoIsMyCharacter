using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WhoIsMyDnDCharacter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Random rand = new Random();

		public List<string> backgrounds = new List<string>();
		public List<string> races = new List<string>();
		public List<string> subraces = new List<string>();
		public List<string> classes = new List<string>();
		public List<string> subclasses = new List<string>();

		public MainWindow()
		{
			InitializeComponent();
			fillBackgroundArray();
			fillRaceArray();
			fillClassArray();
		}

		private void fillBackgroundArray()
		{
			backgrounds.Add("Acolyte");
			backgrounds.Add("Charlatan");
			backgrounds.Add("Criminal");
			backgrounds.Add("Entertainer");
			backgrounds.Add("Folk Hero");
			backgrounds.Add("Guild Artisan");
			backgrounds.Add("Hermit");
			backgrounds.Add("Noble");
			backgrounds.Add("Outlander");
			backgrounds.Add("Sage");
			backgrounds.Add("Sailor");
			backgrounds.Add("Soldier");
			backgrounds.Add("Urchin");
			backgrounds.Add("Haunted One");
			backgrounds.Add("City Watch");
			backgrounds.Add("Clan Crafter");
			backgrounds.Add("Cloistered Scholar");
			backgrounds.Add("Courtier");
			backgrounds.Add("Faction Agent");
			backgrounds.Add("Far Traveler");
			backgrounds.Add("Inheritor");
			backgrounds.Add("Knight of the Order");
			backgrounds.Add("Mercenary Veteran");
			backgrounds.Add("Urban Bounty Hunter");
			backgrounds.Add("Uthgardt");
			backgrounds.Add("Waterdhavian Noble");

		}

		private void fillRaceArray()
		{
			races.Add("Aarakocra");
			races.Add("Aasimar");
			races.Add("Bugbear");
			races.Add("Changling");
			races.Add("Dragonborn");
			races.Add("Dwarf");
			races.Add("Elf");
			races.Add("Firbolg");
			races.Add("Genasi");
			races.Add("Gnome");
			races.Add("Goblin");
			races.Add("Goliath");
			races.Add("Halfling");
			races.Add("Half-elf");
			races.Add("Half-orc");
			races.Add("Hobgoblin");
			races.Add("Human");
			races.Add("Kenku");
			races.Add("Kobold");
			races.Add("Lizard-folk");
			races.Add("Orc");
			races.Add("Shifter");
			races.Add("Tabaxi");
			races.Add("Tiefling");
			races.Add("Triton");
			races.Add("Yuan-ti");
		}

		private void fillSubraceArray(string race)
		{
			subraces.Clear();

			if (race == "Aasimar")
			{
				subraces.Add("Protector");
				subraces.Add("Scourge");
				subraces.Add("Fallen");
			}
			else if (race == "Dragonborn")
			{
				subraces.Add("Fire-Type");
				subraces.Add("Acid-Type");
				subraces.Add("Lightning-Type");
				subraces.Add("Poison-Type");
				subraces.Add("Cold-Type");
			}
			else if (race == "Dwarf")
			{
				subraces.Add("Hill");
				subraces.Add("Mountain");
				subraces.Add("Duergar");

			}
			else if (race == "Elf")
			{
				subraces.Add("Wood");
				subraces.Add("Half");
				subraces.Add("Drow");
				subraces.Add("Eladrin");

			}
			else if (race == "Genasi")
			{
				subraces.Add("Air");
				subraces.Add("Earth");
				subraces.Add("Fire");
				subraces.Add("Water");

			}
			else if (race == "Gnome")
			{
				subraces.Add("Forest");
				subraces.Add("Rock");
				subraces.Add("Deep");

			}
			else if (race == "Halfling")
			{
				subraces.Add("Lightfoot");
				subraces.Add("Stout");
				subraces.Add("Ghostwise");

			}
			else if (race == "Half-Elf")
			{
				subraces.Add("Half-Wood");
				subraces.Add("Half-Sun/Moon");
				subraces.Add("Half-Drow");
				subraces.Add("Half-Aquatic");
				subraces.Add("N/A");

			}
			else if (race == "Human")
			{
				subraces.Add("N/A");
				subraces.Add("Variant");

			}
			else if (race == "Shifter")
			{
				subraces.Add("Beasthide");
				subraces.Add("Cliffwalk");
				subraces.Add("Longstride");
				subraces.Add("Longtooth");
				subraces.Add("Razorclaw");
				subraces.Add("Wildhunt");

			}
			else if (race == "Tiefling")
			{
				subraces.Add("Feral");
				subraces.Add("N/A");

			}
			else subraces.Add("N/A");

			buildSubRace();
		}

		private void fillClassArray()
		{
			classes.Add("Artificer");
			classes.Add("Barbarian");
			classes.Add("Bard");
			classes.Add("Cleric");
			classes.Add("Druid");
			classes.Add("Fighter");
			classes.Add("Monk");
			classes.Add("Mystic");
			classes.Add("Paladin");
			classes.Add("Ranger");
			classes.Add("Rogue");
			classes.Add("Sorcerer");
			classes.Add("Warlock");
			classes.Add("Wizard");
		}

		private void fillSubclassArray(string clas)
		{
			subclasses.Clear();
			if (clas == "Artificer")
			{
				subclasses.Add("Alchemist");
				subclasses.Add("Gunsmith");
			}
			else if (clas == "Barbarian")
			{
				subclasses.Add("Berserker");
				subclasses.Add("Totem Warrior");
				subclasses.Add("Ancestral Guardian");
				subclasses.Add("Storm Herald");
				subclasses.Add("Zealot");

				if (lblRace.Content.ToString() == "Dwarf")
					subclasses.Add("Battlerager");
			}
			else if (clas == "Bard")
			{
				subclasses.Add("Lore");
				subclasses.Add("Valor");
				subclasses.Add("Swords");
				subclasses.Add("Satire");
				subclasses.Add("Glamour");
				subclasses.Add("Whispers");
			}
			else if (clas == "Cleric")
			{
				subclasses.Add("Knowledge");
				subclasses.Add("Life");
				subclasses.Add("Light");
				subclasses.Add("Nature");
				subclasses.Add("Tempest");
				subclasses.Add("Trickery");
				subclasses.Add("War");
				subclasses.Add("Death");
				subclasses.Add("Arcana");
				subclasses.Add("Forge");
				subclasses.Add("Grave");
				subclasses.Add("Protection");
			}
			else if (clas == "Druid")
			{
				subclasses.Add("Land");
				subclasses.Add("Moon");
				subclasses.Add("Dreams");
				subclasses.Add("Shepherd");
				subclasses.Add("Twilight");
			}
			else if (clas == "Fighter")
			{
				subclasses.Add("Champion");
				subclasses.Add("Battle Master");
				subclasses.Add("Eldritch Knight");
				subclasses.Add("Purple Dragon Knight");
				subclasses.Add("Arcane Archer");
				subclasses.Add("Knight");
				subclasses.Add("Samurai");
				subclasses.Add("Monster Hunter");
				subclasses.Add("Cavalier");
				subclasses.Add("Scout");
			}
			else if (clas == "Monk")
			{
				subclasses.Add("Open Hand");
				subclasses.Add("Shadow");
				subclasses.Add("Four Elements");
				subclasses.Add("Long Death");
				subclasses.Add("Sun Soul");
				subclasses.Add("Kensei");
				subclasses.Add("Tranquility");
			}
			else if (clas == "Mystic")
			{
				subclasses.Add("Avatar");
				subclasses.Add("Awakened");
				subclasses.Add("Immortal");
				subclasses.Add("Soul Knife");
				subclasses.Add("Wu Jen");
			}
			else if (clas == "Paladin")
			{
				subclasses.Add("Devotion");
				subclasses.Add("Ancients");
				subclasses.Add("Vengeance");
				subclasses.Add("Crown");
				subclasses.Add("Oathbreaker");
				subclasses.Add("Conquest");
				subclasses.Add("Treachery");
			}
			else if (clas == "Ranger")
			{
				subclasses.Add("Hunter");
				subclasses.Add("Beast Master");
				subclasses.Add("Deep Stalker");
				subclasses.Add("Primeval Guardian");
				subclasses.Add("Horizon Walker");
			}
			else if (clas == "Rogue")
			{
				subclasses.Add("Thief");
				subclasses.Add("Assassin");
				subclasses.Add("Arcane Trickster");
				subclasses.Add("Swashbuckler");
				subclasses.Add("Mastermind");
				subclasses.Add("Inquisitive");
				subclasses.Add("Scout");
			}
			else if (clas == "Sorcerer")
			{
				subclasses.Add("Draconic");
				subclasses.Add("Wild Magic");
				subclasses.Add("Favoured Soul");
				subclasses.Add("Storm");
				subclasses.Add("Shadow");
				subclasses.Add("Phoenix");
				subclasses.Add("Sea");
				subclasses.Add("Stone");
			}
			else if (clas == "Warlock")
			{
				subclasses.Add("Arch-Fey");
				subclasses.Add("Fiend");
				subclasses.Add("Great Old One");
				subclasses.Add("Undying Light");
				subclasses.Add("Seeker");
				subclasses.Add("Hexblade");
				subclasses.Add("Raven Queen");
			}
			else if (clas == "Wizard")
			{
				subclasses.Add("Abjuration");
				subclasses.Add("Conjuration");
				subclasses.Add("Divination");
				subclasses.Add("Enchantment");
				subclasses.Add("Evocation");
				subclasses.Add("Illusion");
				subclasses.Add("Necromancy");
				subclasses.Add("Transmutation");
				subclasses.Add("Theurgy");
				subclasses.Add("Lore");
				subclasses.Add("War Magic");

				if (lblRace.Content.ToString() == "Elf")
					subclasses.Add("Bladesinger");
			}
			else subclasses.Add("N/A");

			buildSubClass();
		}

		private void btnGo_Click(object sender, RoutedEventArgs e)
		{
			buildCharacter();
		}

		private void buildCharacter()
		{
			buildBackground();
			buildStats();
			buildRace();
			buildClass();
		}

		private void buildBackground()
		{
			lblBackground.Content = setRandomBackground();
		}

		private void buildStats()
		{
			lblStr.Content = setRandomAttribute();
			lblDex.Content = setRandomAttribute();
			lblCon.Content = setRandomAttribute();
			lblInt.Content = setRandomAttribute();
			lblWis.Content = setRandomAttribute();
			lblCha.Content = setRandomAttribute();
		}

		private void buildRace()
		{
			string chosenRace = setRandomRace();
			lblRace.Content = chosenRace;
			fillSubraceArray(chosenRace);
		}

		private void buildSubRace()
		{
			lblSubrace.Content = setRandomSubrace();
		}

		private void buildClass()
		{
			string chosenClass = setRandomClass();
			lblClass.Content = chosenClass;
			fillSubclassArray(chosenClass);
		}

		private void buildSubClass()
		{
			lblSubclass.Content = setRandomSubclass();
		}

		private string setRandomRace()
		{
			int result = 0;
			result = rand.Next(1, races.Count + 1);
			result--;

			return races.ElementAt(result);
		}

		private string setRandomSubrace()
		{
			int result = 0;
			result = rand.Next(1, subraces.Count + 1);
			result--;

			return subraces.ElementAt(result);
		}

		private string setRandomClass()
		{
			int result = 0;
			result = rand.Next(1, classes.Count + 1);
			result--;

			return classes.ElementAt(result);
		}

		private string setRandomSubclass()
		{
			int result = 0;
			result = rand.Next(1, subclasses.Count + 1);
			result--;

			return subclasses.ElementAt(result);
		}

		private string setRandomBackground()
		{
			int result = 0;
			result = rand.Next(1, backgrounds.Count + 1);
			result--;

			return backgrounds.ElementAt(result);
		}

		private int setRandomAttribute()
		{
			List<int> rolls = new List<int>();
			int result = 0;

			rolls.Add(rand.Next(1, 7));
			rolls.Add(rand.Next(1, 7));
			rolls.Add(rand.Next(1, 7));
			rolls.Add(rand.Next(1, 7));

			rolls.Sort();
			rolls.Reverse();
			for (int x = 0; x < 3; x++)
			{
				result += rolls[x];
			}
			return result;
		}
	}
}
