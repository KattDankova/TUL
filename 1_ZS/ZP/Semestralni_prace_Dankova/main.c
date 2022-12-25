#include <stdio.h>

int main() {
    //Uvod
    printf("\n\033[1;36m                                                 Vitejte u hry Morra!\n\033[3;35m");
    printf("\n                                       V teto hre hrajete proti jinemu hraci.\033[1;33m");
    printf("\n        /')    ./')                    \033[3;35mKazdy z vas ukaze na ruce pocet prstu.                   \033[1;33m('\\.    ('\\ ");
    printf("\n      /' /.--''./'')                   \033[3;35mNejmensi pocet prstu je 0 a nejvyssi 5.                 \033[1;33m(''\\.''--.\\ '\\ ");
    printf("\n :--''  ;    ''./'')     \033[3;35mPote oba hraci vyrknou svuj odhad kolik oba dohromady ukazi prstu.    \033[1;33m(''\\.''    ;  ''--:");
    printf("\n :     '     ''./')        \033[3;35mJelikoz oba hraci nemusi ukazat zadny prst odhad muze byt od 0       \033[1;33m('\\.''     '     :");
    printf("\n :           ''./'          \033[3;35mna kazdy muze ukazat maximalne 5 prstu, maximalni odhad je 10.       \033[1;33m'\\.''           :");
    printf("\n :--''-..--''''               \033[3;35mKdyz hrac spravne uhodne pocet ukazanych prstu ziska bod.             \033[1;33m''''--..-''--:");
    printf("\n                         \033[3;35mPokud uhadnou oba hraci, jedna se o temizu a nikdo bod neziskava.");
    printf("\n                                  Hra konci, ve chvili jeden z hracu ziska 5 bodu.");

    //Inicializace
    int player_points = 0;
    int pc_points = 0;
    srand(time(NULL));

    //Pocitadlo kol
    for (int i = 1;; i++) {
        printf("\n\n\033[1;31m%d. Kolo\n\n", i);

        //Pocet prstu
        int fingers;
        int temp = 0;
        //Osetreni poctu prstu (minimalne 0 a maximalne 5 prstu)
        do {
            printf("\033[1;37mZadejte pocet prstu: ");
            temp = scanf("%d", & fingers);
            //Osetreni ze zadane cislo je opravdu cislo
            while (temp != 1) {
                scanf("%*[^\n]");
                printf("\n\033[0;31mProsim, zadejte cislo: \033[0;37m");
                temp = scanf("%d", & fingers);
            }
        } while (fingers < 0 || fingers > 5);

        //Odhad
        int guess;
        temp = 0;
        //Osetreni odhadu (minimalne 0 a maximalne 10 prstu)
        do {
            printf("Zadejte odhad celkovych prstu: ");
            temp = scanf("%d", & guess);
            //Osetreni ze zadane cislo je opravdu cislo
            while (temp != 1) {
                scanf("%*[^\n]");
                printf("Prosim, zadejte cislo: ");
                temp = scanf("%d", & guess);
            }
        } while (guess < 0 || guess > 10);

        //PC tah
        int pc_fingers = Random(0, 5);
        int max = 0;

        //Nastaveni maxima (aby kdyz zada napriklad 3, vedel ze maximum muze byt pouze 3+5=8)
        if (pc_fingers + 5 > 10) {
            max = 10;
        } else {
            max = pc_fingers + 5;
        }
        int pc_guess = Random(pc_fingers, max);

        //Graficke znazorneni kola
        DrawHand(fingers, "Hrac", guess);

        printf("\n\033[1;36m                            Soucet: %d", fingers + pc_fingers);

        //Pridani bodu
        if (guess != pc_guess && guess == fingers + pc_fingers) {
            player_points++;
            printf("\033[0;31m                 Hrac ziskava bod! Nyni ma jiz %d bod(u)\n", player_points);
        } else if (guess != pc_guess && pc_guess == fingers + pc_fingers) {
            pc_points++;
            printf("\033[0;31m                 Pocitac ziskava bod! Nyni ma jiz %d bod(u)\n", pc_points);
        }

        DrawHand(pc_fingers, "Pocitac", pc_guess);

        //Konec hry
        if (player_points == 5) {
            printf("\n\033[3;35m                                                Konec hry - Hrac vyhral!\n\n\n");
            break;
        } else if (pc_points == 5) {
            printf("\n\033[3;35m                                                Konec hry - Pocitac vyhral!\n\n\n");
            break;
        }
    }
    return 0;
}

//Metoda pro vytvoreni randomu s minimalni a maximalni hodnotou
int Random(int min, int max) {
    return min + rand() % (max + 1 - min);
}

//Metoda pro vyklesleni poctu prstu
void DrawHand(int fingers, char who[], int guess) {
    int color;
    if (who == "Hrac") {
        color = 2;
    } else {
        color = 6;
    }
    printf("\033[1;33m");
    switch (fingers) {
    case 0:
        printf("\n    _____");
        printf("\n---'   __\\_                 \033[0;3%dm%s\033[1;33m", color, who);
        printf("\n          _)                \033[0;3%dmPocet prstu: %d\033[1;33m", color, fingers);
        printf("\n          __)               \033[0;3%dmOdhad: %d\033[1;33m", color, guess);
        printf("\n         __)");
        printf("\n---.______)");
        break;
    case 1:
        printf("\n       _");
        printf("\n      / )");
        printf("\n    .' /                    \033[0;3%dm%s\033[1;33m", color, who);
        printf("\n---'  (____                 \033[0;3%dmPocet prstu: %d\033[1;33m", color, fingers);
        printf("\n          _)                \033[0;3%dmOdhad: %d\033[1;33m", color, guess);
        printf("\n          __)");
        printf("\n         __)");
        printf("\n---.______)");
        break;
    case 2:
        printf("\n           _");
        printf("\n   _     / /");
        printf("\n  \\ \\   / /");
        printf("\n   \\ \\ / /                  \033[0;3%dm%s\033[1;33m", color, who);
        printf("\n    \\ V  Y-.                \033[0;3%dmPocet prstu: %d\033[1;33m", color, fingers);
        printf("\n   / \\    ` |               \033[0;3%dmOdhad: %d\033[1;33m", color, guess);
        printf("\n   | |      |");
        printf("\n   \\        |");
        printf("\n    |      /");
        printf("\n    |     |");
        break;
    case 3:
        printf("\n           _");
        printf("\n   _     / /");
        printf("\n  \\ \\   / /");
        printf("\n   \\ \\ / /                  \033[0;3%dm%s\033[1;33m", color, who);
        printf("\n  _ \\ V  Y-.                \033[0;3%dmPocet prstu: %d\033[1;33m", color, fingers);
        printf("\n \\ `\\     ` |               \033[0;3%dmOdhad: %d\033[1;33m", color, guess);
        printf("\n  \\         |");
        printf("\n   \\        |");
        printf("\n    |      /");
        printf("\n    |     |");
        break;
    case 4:
        printf("\n    .-.");
        printf("\n  .-| |-.");
        printf("\n  | | | |");
        printf("\n  | | | |-.");
        printf("\n  | | | | |                 \033[0;3%dm%s\033[1;33m", color, who);
        printf("\n  |_|_|_| |                 \033[0;3%dmPocet prstu: %d\033[1;33m", color, fingers);
        printf("\n / )    `-|                 \033[0;3%dmOdhad: %d\033[1;33m", color, guess);
        printf("\n| | `--   |");
        printf("\n|     ||  |");
        printf("\n\\     '   /");
        printf("\n |       |");
        printf("\n |       |");
        break;
    case 5:
        printf("\n   _.-._");
        printf("\n  | | | |_");
        printf("\n  | | | | |");
        printf("\n  | | | | |                 \033[0;3%dm%s\033[1;33m", color, who);
        printf("\n  | | | | |                 \033[0;3%dmPocet prstu: %d\033[1;33m", color, fingers);
        printf("\n_ |  '-._ |                 \033[0;3%dmOdhad: %d\033[1;33m", color, guess);
        printf("\n\\`\\`-.'-._;");
        printf("\n \\    '   |");
        printf("\n  \\  .`  /");
        printf("\n   |    |");
        break;
    }
    printf("\033[1;37m\n");
}
