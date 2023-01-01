#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>

char NPC[] = "Pocitac";
char PLAYER[] = "Hrac";
int MAX_NUMBER_OF_FINGERS = 5;
int MAX_NUMBER_OF_POINTS = 5;

//Pouzite barvicky
char TURQUOISE[] = "\033[1;36m";
char PURPLE[] = "\033[3;35m";
char YELLOW[] = "\033[1;33m";
char LIGHT_RED[] = "\033[1;31m";
char WARNING_RED[] = "\033[0;31m";
char WHITE[] = "\033[1;37m";
char GOLD[] = "\033[0;33m";

int entering_number(void)
{
    int number;
    while (scanf("%d", &number) != 1)
    {
        printf("%s Zadali jste spatne.\n", WARNING_RED);
        while (getchar() != '\n')
            ;
        printf("%s Zadejte cele cislo: ", WHITE);
    }
    while (getchar() != '\n')
        ;
    return number;
}

int entering_number_in_interval(int min, int max)
{
    int number;
    printf("%s Zadejte pocet prstu (od %d do %d): ", WHITE, min, max);
    while ((number = entering_number()) < min || number > max)
    {
        printf("%s Zadali jste cislo mimo intreval.\n", WARNING_RED);
        printf("%s Zadejte pocet prstu (od %d do %d): ", WHITE, min, max);
    }
    return number;
}

//Metoda pro vytvoreni randomu s minimalni a maximalni hodnotou
int random(int min, int max)
{
    return min + rand() % (max + 1 - min);
}

//Metoda pro vyklesleni poctu prstu
void drawHand(int fingers, char who[], int guess)
{
    char color[] = "\033[0;32m";
    if (strcmp(who, NPC))
    {
        strcat(color, "\033[0;36m");
    }
    printf("%s", YELLOW);
    switch (fingers)
    {
        case 0:
            printf("\n     _____");
            printf("\n ---'   __\\_                %s %s %s", color, who, YELLOW);
            printf("\n           _)               %s Pocet prstu: %d %s", color, fingers, YELLOW);
            printf("\n           __)              %s Odhad: %d%s", color, guess, YELLOW);
            printf("\n          __)");
            printf("\n ---.______)");
            break;
        case 1:
            printf("\n        _");
            printf("\n       / )");
            printf("\n     .' /                   %s %s %s", color, who, YELLOW);
            printf("\n ---'  (____                %s Pocet prstu: %d %s", color, fingers, YELLOW);
            printf("\n           _)               %s Odhad: %d %s", color, guess, YELLOW);
            printf("\n           __)");
            printf("\n          __)");
            printf("\n ---.______)");
            break;
        case 2:
            printf("\n            _");
            printf("\n    _     / /");
            printf("\n   \\ \\   / /");
            printf("\n    \\ \\ / /                 %s %s %s", color, who, YELLOW);
            printf("\n     \\ V  Y-.               %s Pocet prstu: %d %s", color, fingers, YELLOW);
            printf("\n    / \\    ` |              %s Odhad: %d %s", color, guess, YELLOW);
            printf("\n    | |      |");
            printf("\n    \\        |");
            printf("\n     |      /");
            printf("\n     |     |");
            break;
        case 3:
            printf("\n            _");
            printf("\n    _     / /");
            printf("\n   \\ \\   / /");
            printf("\n    \\ \\ / /                 %s %s %s", color, who, YELLOW);
            printf("\n   _ \\ V  Y-.               %s Pocet prstu: %d %s", color, fingers, YELLOW);
            printf("\n  \\ `\\     ` |              %s Odhad: %d %s", color, guess, YELLOW);
            printf("\n   \\         |");
            printf("\n    \\        |");
            printf("\n     |      /");
            printf("\n     |     |");
            break;
        case 4:
            printf("\n     .-.");
            printf("\n   .-| |-.");
            printf("\n   | | | |");
            printf("\n   | | | |-.");
            printf("\n   | | | | |                %s %s %s", color, who, YELLOW);
            printf("\n   |_|_|_| |                %s Pocet prstu: %d %s", color, fingers, YELLOW);
            printf("\n  / )    `-|                %s Odhad: %d %s", color, guess, YELLOW);
            printf("\n | | `--   |");
            printf("\n |     ||  |");
            printf("\n \\     '   /");
            printf("\n  |       |");
            printf("\n  |       |");
            break;
        case 5:
            printf("\n    _.-._");
            printf("\n   | | | |_");
            printf("\n   | | | | |");
            printf("\n   | | | | |                %s %s %s", color, who, YELLOW);
            printf("\n   | | | | |                %s Pocet prstu: %d %s", color, fingers, YELLOW);
            printf("\n _ |  '-._ |                %s Odhad: %d %s", color, guess, YELLOW);
            printf("\n \\`\\`-.'-._;");
            printf("\n  \\    '   |");
            printf("\n   \\  .`  /");
            printf("\n    |    |");
            break;
        default:
            printf("\n   %s CHYBA PRI ZADANI POCTU PRSTU!!", WARNING_RED);
    }

    printf("\n");
}

int main()
{
    int fingers, guess, pc_fingers, max, player_points = 0, pc_points = 0, round = 1;
    srand(time(NULL));

    //Uvod
    printf("\n                                               %s Vitejte u hry Morra!\n", TURQUOISE);
    printf("\n                                      %s V teto hre hrajete proti jinemu hraci.", PURPLE);
    printf("\n%s        /')    ./')                   %s Kazdy z vas ukaze na ruce pocet prstu.                   %s('\\.    ('\\ ", YELLOW, PURPLE, YELLOW);
    printf("\n      /' /.--''./'')                  %s Nejmensi pocet prstu je 0 a nejvyssi %d.                 %s(''\\.''--.\\ '\\ ", PURPLE, MAX_NUMBER_OF_FINGERS, YELLOW);
    printf("\n :--''  ;    ''./'')    %s Pote oba hraci vyrknou svuj odhad kolik oba dohromady ukazi prstu.    %s(''\\.''    ;  ''--:", PURPLE, YELLOW);
    printf("\n :     '     ''./')       %s Jelikoz oba hraci nemusi ukazat zadny prst odhad muze byt od 0       %s('\\.''     '     :", PURPLE, YELLOW);
    printf("\n :           ''./'         %s na kazdy muze ukazat maximalne %d prstu, maximalni odhad je %d.       %s'\\.''           :", PURPLE, MAX_NUMBER_OF_FINGERS, MAX_NUMBER_OF_FINGERS * 2, YELLOW);
    printf("\n :--''-..--''''              %s Kdyz hrac spravne uhodne pocet ukazanych prstu ziska bod.             %s''''--..-''--:", PURPLE, YELLOW);
    printf("\n                        %s Pokud uhadnou oba hraci, jedna se o temizu a nikdo bod neziskava.", PURPLE);
    printf("\n                                  Hra konci, ve chvili jeden z hracu ziska %d bodu.\033[0;31m", MAX_NUMBER_OF_POINTS);

    //Pocitadlo kol
    do
    {
        printf("\n\n %s %d. Kolo\n\n", LIGHT_RED, round);

        //Hrac
        printf("%s Vas tah:\n", WHITE);
        fingers = entering_number_in_interval(0, MAX_NUMBER_OF_FINGERS);
        printf("%s Vas odhad:\n", WHITE);
        guess = entering_number_in_interval(fingers, MAX_NUMBER_OF_FINGERS * 2);

        //PC tah
        pc_fingers = random(0, MAX_NUMBER_OF_FINGERS);
        max = 0;

        //Nastaveni maxima (aby kdyz zada napriklad 3, vedel ze maximum muze byt pouze 3+5=8)
        if (pc_fingers + MAX_NUMBER_OF_FINGERS > MAX_NUMBER_OF_FINGERS * 2)
        {
            max = MAX_NUMBER_OF_FINGERS * 2;
        }
        else
        {
            max = pc_fingers + MAX_NUMBER_OF_FINGERS;
        }
        int pc_guess = random(pc_fingers, max);

        //Graficke znazorneni kola
        drawHand(fingers, PLAYER, guess);
        printf("\n                           %s Soucet: %d", TURQUOISE, fingers + pc_fingers);
        //Pridani bodu
        if (guess != pc_guess && guess == fingers + pc_fingers)
        {
            player_points++;
            printf("%s                 %s ziskava bod! Nyni ma jiz %d bod(u)\n", GOLD, PLAYER, player_points);
        }
        else if (guess != pc_guess && pc_guess == fingers + pc_fingers)
        {
            pc_points++;
            printf("%s                 %s ziskava bod! Nyni ma jiz %d bod(u)\n", GOLD, NPC, pc_points);
        }
        else if (guess == pc_guess && guess == fingers + pc_fingers)
        {
            printf("%s                 Remiza! Nikdo neziskava bod.\n", GOLD);
        }

        drawHand(pc_fingers, NPC, pc_guess);
        round++;
    } while (player_points < MAX_NUMBER_OF_POINTS && pc_points < MAX_NUMBER_OF_POINTS);


    //Konec hry
    if (player_points == MAX_NUMBER_OF_POINTS)
    {
        printf("\n%s                                                Konec hry - %s vyhral!\n\n\n", PURPLE, PLAYER);

    }
    else if (pc_points == MAX_NUMBER_OF_POINTS)
    {
        printf("\n%s                                             Konec hry - %s vyhral!\n\n\n", PURPLE, NPC);

    }
    return 0;
}
