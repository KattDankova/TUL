#include <stdio.h>

int main() {
    //Inicializace bodu pro hrace a pro pocitac
    int player_points = 0;
    int pc_points = 0;
    //inicializace randomu
    srand(time(NULL));

    //Pocitadlo kol
    for (int i = 1;; i++) {
        printf("%d. Kolo\n", i);

        //Pocet prstu
        int fingers;
        int temp = 0;
        //Osetreni poctu prstu (minimalne 0 a maximalne 5 prstu)
        do {
            printf("Zadejte pocet prstu (0-5): \n");
            temp = scanf("%d", &fingers);
            //Osetreni ze zadane cislo je opravdu cislo
            while (temp != 1) {
                scanf("%*[^\n]");
                printf("Prosim, zadejte cislo: \n");
                temp = scanf("%d", &fingers);
            }
        } while (fingers < 0 || fingers > 5);

        //Odhad
        int guess;
        temp = 0;
        //Osetreni odhadu (minimalne 0 a maximalne 10 prstu)
        do {
            printf("Ted zadejte odhad celkovych prstu, hrajete proti pocitaci a kazdy z vas ma 5 prstu, tudiz odhad musi byt mezi 0 a 10: \n", );
            temp = scanf("%d", &guess);
            //Osetreni ze zadane cislo je opravdu cislo
            while (temp != 1) {
                scanf("%*[^\n]");
                printf("Prosim, zadejte cislo: \n");
                temp = scanf("%d", &guess);
            }
        } while (guess < 0 || guess > 10);

        printf("Hrac: %d\n", fingers);
        printf("Odhad: %d\n", guess);

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

        printf("PC: %d\n", pc_fingers);
        printf("Odhad PC: %d\n", pc_guess);
        printf("Soucet: %d\n", fingers + pc_fingers);

        //Pridani bodu
        if (guess != pc_guess && guess == fingers + pc_fingers) {
            player_points++;
            printf("Hrac ziskava bod!\n Nyni ma jiz %d bodu\n", player_points);
        } else if (guess != pc_guess && pc_guess == fingers + pc_fingers) {
            pc_points++;
            printf("Pocitac ziskava bod!\n Nyni ma jiz %d bodu\n", pc_points);
        }

        //Konec hry
        if (player_points == 2) {
            printf("Hrac vyhral!");
            break;
        } else if (pc_points == 2) {
            printf("Pocitac vyhral!");
            break;
        }
    }
    return 0;
}

int Random(int min, int max) {
    return min + rand() % (max + 1 - min);
}
