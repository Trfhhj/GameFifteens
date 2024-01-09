using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteens2
{
    class Game
    {
        int size;
        int[,] map;
        int space_x, space_y; // места, где записаны пробелы
        static Random rand = new Random();

        // размер игрового поля
        public Game (int size)
        {
            if (size < 2) size = 2;
            if (size > 5) size = 5;
            this.size = size;
            map = new int [size, size];
        }

        // подготовка поля к игре, заполнение поля цифрами
        public void start ()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    map[x, y] = coords_to_position(x, y) + 1;
            space_x = size - 1;
            space_y = size - 1;
            map[space_x, space_y] = 0; // это пробел, свободное место 
        }

        public void shift(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (Math.Abs(space_x - x) + Math.Abs(space_y - y) != 1)
                return;
            map[space_x, space_y] = map[x, y];
            map[x, y] = 0;
            space_x = x;
            space_y = y;
        }

        // функция делает одно случайное перемещение
        public void shift_random()
        {
            // shift (rand.Next(0, size * size));
            int a = rand.Next(0, 4);
            int x = space_x; // координата пустой плашки по x
            int y = space_y; // координата пустой плашки по y
            switch (a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }
            shift(coords_to_position(x, y));
        }

        public bool check_numbers ()
        {
            // проверка последняя клетка пустая или нет
            if (!(space_x == size - 1 && space_y == size - 1))
                return false;
            // если да, то идем сначала и проверяем в порядке возрастания ли числа
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if (!(x == size - 1 && y == size - 1))
                        if (map[x, y] != coords_to_position(x, y) + 1)
                        return false;
            return true;
        }
        // вернёт цифру, находящуюся в нужном месте
        public int get_number(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (x < 0 || x >= size) return 0; //предотвращение ошибки переполнения массива
            if (y < 0 || y >= size) return 0; //предотвращение ошибки переполнения массива
            return map[x, y];
        }
        // координаты переводит в позиции (номер кнопки)
        private int coords_to_position(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }
        // обратное действие (из номера кнопки в координаты)
        private void position_to_coords(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }
        
    }
}
