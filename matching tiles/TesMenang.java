package ZicZacZoe;

import java.util.Scanner;

public class TesMenang {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int[][] papan = {
            {0, 0, 0, 0, 0},
            {0, 0, 1, 0, 0},
            {0, 1, 1, 1, 0},
            {0, 0, 0, 1, 1},
            {0, 0, 0, 0, 0}
        };
        int[][][] kartu = {
            {{0,1},{1,1},{1,2},{2,0},{2,1},{3,0}},//tegak
            {{0,2},{1,1},{1,2},{2,0},{2,1},{3,1}},//terbalik
            {{0,0},{0,1},{1,1},{1,2},{1,3},{2,2}},//miring kanan
            {{0,1},{1,0},{1,1},{1,2},{2,2},{2,3}}//miring kiri
        };
        int[][] kondisiPemain = {{1,2},{2,2},{2,3},{3,1},{3,2},{4,1}};
        System.out.println(cekKondisi(kartu, kondisiPemain)?"menang":"lanjut");
        int[][] kondisiPemain2 = {{1,1},{1,2},{2,2},{2,3},{2,4},{3,3}};
        System.out.println(cekKondisi(kartu, kondisiPemain2)?"menang":"lanjut");
    }
    public static boolean cekKondisi(int[][][] kartu, int[][] kondisi){
        int benar = 0;
        boolean hasil = false;
        for (int i = 0; i < kartu.length; i++) {
            int porosX = kondisi[0][0];
            int porosY = kondisi[0][1];
            int perubahanX = kartu[i][0][0]-porosX;
            int perubahanY = kartu[i][0][1]-porosY;
            System.out.println(perubahanX);
            System.out.println(perubahanY);
            benar = 0;
            if(i == 0){
                System.out.println("tegak");
            }else if(i == 1){
                System.out.println("terbalik");
            }else if(i == 2){
                System.out.println("kanan");
            }else if(i == 3){
                System.out.println("kiri");
            }
            for(int j = 0 ; j < kartu[i].length ; j++){
                System.out.println(kartu[i][j][0] + " " + kartu[i][j][1] + "  " + (kondisi[j][0]+perubahanX) + " " + (kondisi[j][1]+perubahanY)+ "  " + (kondisi[j][0]) + " " + (kondisi[j][1]));
                if(kartu[i][j][0]==kondisi[j][0]+perubahanX &&kartu[i][j][1]==kondisi[j][1]+perubahanY ){
                    benar++;
                }
            }
            if(benar == 6){
             hasil = true;
             break;
         }
         
         
     }
     return hasil;
 }
 
}
