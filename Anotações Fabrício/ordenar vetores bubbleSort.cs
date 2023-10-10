   int[] vetor = new int[10] { 10, 7, 3, 6, 9, 1, 2, 5, 8, 4 };
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < (vetor.Length - 1); j++)
                {
                    if (vetor[j + 1] < vetor[j])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j+1] = aux;
                    }
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Vetor[" + i + "] = " + vetor[i]);
            }
