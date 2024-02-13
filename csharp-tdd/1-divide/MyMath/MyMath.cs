﻿using System;

namespace MyMath{
    public class Matrix{
        
        /// <summary>
        /// Divides all elements of a matrix by a specified number.
        /// </summary>
        /// <param name="matrix">The matrix to be divided.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>A new matrix with each element divided by num, or null if num is 0 or matrix is null.</returns>
        public static int[,] Divide(int[,] matrix, int num){
            try{
                if(num == 0){
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                int[,] newMatrix = new int[rows, columns];

                for(int i = 0; i < rows; i++){
                    for(int j = 0; j < columns; j++){
                        newMatrix[i,j] = (matrix[i,j] / num);
                    }
                }

                return newMatrix;

            }catch(Exception e){
                     return null;
            }
               
        }
        }
    }
