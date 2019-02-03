namespace exercicio_params {
    public class Calculator {
        public static int Sum (params int[] numbers) { // params indica que ira receber uma quanta variavel de valores que sao passados sem a necessidade de criar um vetor
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}