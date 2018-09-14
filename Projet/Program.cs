using System;

namespace Projet
{
    class Program
    {
        public static int choix2 { get; private set; }
        public static int Boiresang { get; private set; }
        static void Main(string[] args)
        {




            Random Generateur = new Random();

            int habileteManoroth = 3;
            int totalAttaquemanoroth;
            int vieManoroth = 60;

            int totalAttaquegromash;
            int totalAttaquegarrosh;
            int vieGrommash = 20;
            int vieGarrosh = 25;
            int habileteGarrosh = 7;
            int habilete = 5;
            int chance = 5;
            int Totalchance;

            int Totalhabilete;

            Console.WriteLine("Vous êtes Grommash hurlenfer chef du clan chanteguerre et chef de la horde de fer");
            Console.ReadKey();
            Console.WriteLine("Vous vous trouvez, vous et vôter horde devant le trône de kil'Jaiden. Vous vousapprochez du démoniste Gul'Dan et de son chaudron qui contient le sang de manoroth et il vous tient ce discours");
            Console.ReadKey();
            Console.WriteLine("Guldan: Bois hurlenfer, revendique ta destiné vous deviendrez des conquérants !");
            Console.ReadKey();
            Console.WriteLine("Si vous decidez de ne pas boire le sang tapez 2 si par contre vous decider de le boire tapez 1 ");





            while (Boiresang != 1 && Boiresang != 2)
            {
                int Boiresang = Convert.ToInt32(Console.ReadLine());

                if (Boiresang == 1) // Bois le sang 
                {
                    Console.Clear();
                    Console.WriteLine("Vous avez décidé de le boire en connaissant sa dangerosité mias vous voulez absolumemt accroitre votre pouvoir");
                    Console.ReadKey();
                    Console.WriteLine("On va maintenant tester votre chance, le fonctionnement est très simple, Vous commencer avec 5 de chance un nombre aleatoire sera generer entre 1 et 6 ");
                    Console.ReadKey();
                    Console.WriteLine("si le total est égal ou supérieur a 7 vous etes chanceux, sinon vous subirer les conséquences, a chaque vois que vous tenterez votre chance vous perdrez un point de total de chance");
                    Console.ReadKey();
                    Console.WriteLine("Testons votre chance");
                    Console.ReadKey();
                    int dés = Generateur.Next(1, 7);
                    Totalchance = dés + chance;
                    Console.WriteLine("Votre Total de chance est de " + Totalchance);
                    Console.ReadKey();

                    if (Totalchance >= 7) // Si vous êtes chanceux
                    {
                        Console.Clear();
                        Console.WriteLine("vous etes chanceux, le sang ne vous a pas tué et vous sentez votre puissance s'accroitre");
                        Console.ReadKey();
                        Console.WriteLine("Néanmoins vouDans vôtre folie vous vous blessez vous perdez 1 point d'habileté et 1 point de chance");
                        Totalchance = chance - 1;
                        Totalhabilete = habilete - 1;
                        Console.WriteLine("Il  vous reste donc " + Totalhabilete + " point d'habileté et " + Totalchance + " point de chance");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Vous êtes désrmais esclaves de la légion, possédé parle sang de manoroth");
                        Console.ReadKey();
                        Console.WriteLine("Vous vous préparez à affronter votre fils , garrosh Hurlenfer qui vous avez prévenu de ne pas le boire");
                        Console.WriteLine("Si vous voulez tentez votre chance pour récuperez vospoint d'habileté tapez 1 sinon tapez 2 mais aite attention si vous échouez ici la suitede l'aventure pourrait être compromise");

                        while (choix2 != 1 || choix2 != 2)
                        {

                            int choix2 = Convert.ToInt32(Console.ReadLine()); // choix de gain habilete pour combat vs garrosh

                            if (choix2 == 1)
                            {
                                Console.WriteLine("Vous avez décidez de tenter votre chance, voyons voir si vous êtes encore chanceux");
                                int dés2 = Generateur.Next(1, 7);
                                Totalchance = dés + chance;
                                Console.WriteLine("Votre Total de chance est de " + Totalchance);
                                Console.ReadKey();

                                if (Totalchance >= 7) // Chanceux habileté
                                {
                                    Console.WriteLine("Votre audace a payé vous gagner deux points d'habileté");
                                    Console.ReadKey();
                                    Totalhabilete = habilete + 2;
                                    Console.WriteLine("Vous avez donc " + Totalhabilete + " points");
                                    Console.ReadKey();
                                }
                                else // malchanceux habileté
                                {

                                    Console.WriteLine("AIE dans votre malheur vous perdez encore deux points d'habileté");
                                    Totalhabilete = habilete - 2;
                                    Console.ReadKey();
                                    Console.WriteLine("Il vous reste " + Totalhabilete + " point d'habilté");
                                    Console.ReadKey();


                                }
                            }
                            else if (choix2 == 2)  // Choix safe habilete
                            {
                                Console.WriteLine("Vous avez décider de jouer safe vous conserez donc vos points d'habileté");
                                Console.ReadKey();
                            }

                            else //Tete de mort qui fait n'importe quoi
                            {
                                Console.WriteLine("Veuillez taper 1 ou 2");
                            }
                        }

                            Console.Clear();
                            Console.WriteLine("Le début du combat va commencer, voici les explications :"); // Start explication 
                            Console.ReadKey();
                            Console.WriteLine("Vous avez " + Totalchance + " points d'habileté plus un nombre d'attaque générer entre  1 et 6");
                            Console.ReadKey();
                            Console.WriteLine("Si votre total d'attaque est supérieur à celui de garrosh vous lui infliger 5 points de dégats");
                            Console.ReadKey();
                            Console.WriteLine("Par contre si garrosh a plus d'attaque que vous c'est vous qui perdez 5 points de vies");
                            Console.ReadKey();
                            Console.WriteLine("Et si vous avez fait égalité, personne ne prends des dégats, c'est partit");
                            Console.ReadKey();
                            Console.Clear();
                            while (vieGarrosh != 0 || vieGrommash != 0) // Boucle tant qu'un personnage est en vie
                            {

                                int attaqueGarrosh = Generateur.Next(1, 7); // generateur ataque garrosh
                                int attaqueGromash = Generateur.Next(1, 7); // generateur attaque gromash
                                totalAttaquegarrosh = attaqueGarrosh + habileteGarrosh;
                                totalAttaquegromash = attaqueGromash + habilete;

                                if (totalAttaquegromash < totalAttaquegarrosh)
                                {
                                    Console.WriteLine("Garrosh vous a infligé 5 points de dégats");
                                    vieGrommash = vieGrommash - 5;
                                    Console.ReadKey();
                                    Console.WriteLine("Il vous reste " + vieGrommash + " points de vies");
                                    Console.ReadKey();


                                }

                                else if (totalAttaquegromash > totalAttaquegarrosh)
                                {
                                    Console.WriteLine("Vous avez  infligé 5 points de dégats");
                                    vieGarrosh = vieGarrosh - 5;
                                    Console.ReadKey();
                                    Console.WriteLine("Il  reste " + vieGarrosh + " points de vies à garrosh");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    Console.WriteLine("Egalité personne n'est blessé");
                                }

                                if (vieGrommash <= 0)
                                {
                                    Console.WriteLine("Vous êtes mort, EH OUI, soyez plus chanceux la prochaine fois");
                                    Console.ReadKey();
                                    return;


                                }
                                else
                                {
                                    Console.WriteLine("Vous avez tué votre fils garrosh");
                                    Console.ReadKey();
                                    Console.WriteLine("Posseder par les démons vous allez entrainer votre peuple dans une guerre sanglante");
                                    Console.ReadKey();
                                    Console.WriteLine("Un sombre avenir se présage, c'est le destin que vous vous êtes choisis");
                                    Console.ReadKey();
                                    Console.WriteLine("Merci d'avoir joué :)");
                                    Console.ReadKey();
                                    return;
                                }

                            }
                       
                    }


                    else
                    { // Mort

                        Console.WriteLine("Dommage vous n'êtes pas chanceux, ducoup vous êtes mort :) retentez vôtre chance");
                        return;

                    }


                }










                else if (Boiresang == 2)  // Ne bois pas le sang
                {
                    Console.Clear();
                    Console.WriteLine("Choisissant l'honneur plutot que la puissance, vous décidez de prendre votre destin en main");
                    Console.ReadKey();
                    Console.WriteLine("Ecumant de rage manaroth sort de son ombre et avance vers vous");
                    Console.ReadKey();
                    Console.WriteLine("Vous lancez l'ordre d'envoyer les boules de feu, c'est le moment de tentez votre chance !");
                    Console.ReadKey();
                    Console.WriteLine(" le fonctionnement est très simple, Vous commencer avec 5 de chance un nombre aleatoire sera generer entre 1 et 6 ");
                    Console.ReadKey();
                    Console.WriteLine("si le total est égal ou supérieur a 7 vous etes chanceux, sinon vous subirer les conséquences, a chaque vois que vous tenterez votre chance vous perdrez un point de total de chance");
                    Console.ReadKey();
                    Console.WriteLine("Testons votre chance");
                    Console.ReadKey();
                    int boulefeu = Generateur.Next(1, 7);
                    Totalchance = boulefeu + chance;
                    Console.WriteLine("Votre Total de chance est de " + Totalchance);
                    chance = chance - 1;

                    Console.ReadKey();
                    if (Totalchance >= 7) // Chanceux boule de feu
                    {
                        Console.WriteLine("Votre chance a porté es fruits !");
                        Console.ReadKey();
                        Console.WriteLine("Une boule de feu a touché Manoroth il a perdu 15 pv !");
                        Console.ReadKey();
                        vieManoroth = vieManoroth - 15;



                    }
                    else
                    {
                        Console.WriteLine("Malheur ! la boule de feu vous a touché vous perdez 10 pv :)");
                        Console.ReadKey();
                        vieGrommash = vieGrommash - 10;
                    }

                    Console.WriteLine("Manoroth s'avance vers vous, le combat pour la liberé va comencer!!");
                    Console.ReadKey();
                    while (vieManoroth != 0 || vieGrommash != 0) // Boucle tant qu'un personnage est en vie
                    {

                        int attaqueManoroth = Generateur.Next(1, 7); // generateur ataque Manoroth
                        int attaqueGromash = Generateur.Next(1, 7); // generateur attaque gromash
                        totalAttaquemanoroth = attaqueManoroth + habileteManoroth;
                        totalAttaquegromash = attaqueGromash + habilete;

                        if (totalAttaquegromash < totalAttaquemanoroth)
                        {
                            Console.WriteLine("Manoroth vous a infligé 5 points de dégats");
                            vieGrommash = vieGrommash - 5;
                            Console.ReadKey();
                            Console.WriteLine("Il vous reste " + vieGrommash + " points de vies");
                            Console.ReadKey();


                        }

                        else if (totalAttaquegromash > totalAttaquemanoroth)
                        {
                            Console.WriteLine("Vous avez  infligé 5 points de dégats");
                            vieManoroth = vieManoroth - 5;
                            Console.ReadKey();
                            Console.WriteLine("Il  reste " + vieManoroth + " points de vies à Manoroth");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("Egalité personne n'est blessé");
                            Console.ReadKey();

                        }




                        if (vieGrommash <= 0)
                        {
                            Console.WriteLine("Vous êtes mort, le combat que vous avez lancé pour votre liberté est finit");
                            Console.ReadKey();
                            Console.WriteLine("Votre faiblesse conduiras à la mort de millions d'innocents");
                            Console.ReadKey();
                            return;
                        }

                        else
                    {
                            Console.WriteLine("Manoroth est vincu vous vous redressez dans un élan de gloir et d'euphorie");
                            Console.ReadKey();
                            Console.WriteLine("Vous vous retournez et vous voyez manorth exploser eul la chance peut vous sauvez");
                            int explosion = Generateur.Next(1, 7);
                            Totalchance = explosion + chance;
                            Console.WriteLine("Votre Total de chance est de " + Totalchance);
                            chance = chance - 1;

                            Console.ReadKey();
                            if (Totalchance >= 7)
                            {
                                Console.WriteLine("Garrosh arrive juste à temps pour vous sauvez");
                                Console.ReadKey();
                                Console.WriteLine("Le chef des démons  étant vaincus, l'armée se replie");
                                Console.ReadKey();
                                Console.WriteLine("Votre monde est préservé vous pourrez aspiré à une vie calme et tranquille");
                                Console.ReadKey();
                                Console.WriteLine("Merci d'avoir joué : )");
                                Console.ReadKey();
                                return;
                            }

                            else
                            {
                                Console.WriteLine("Comme vous êtes nul et malchaceux, Garrosh trebucha sur une pierre en voulant vous sauvez");
                                Console.ReadKey();
                                Console.WriteLine("Vous avez périt dans l'éxplosion causé par Manoroth");
                                Console.ReadKey();
                                Console.WriteLine("Personne ne se souviendras de vous car vous êtes nul ");
                                Console.ReadKey();
                                Console.WriteLine("Merci d'avoir joué : )");
                                Console.ReadKey();
                                return;
                            }

                        }



                    }
                    
                    

                    
                }
                else
                {

                    Console.WriteLine("veuillez retapez soit 1 soit 2");
                }
            }




        }
    }
}
