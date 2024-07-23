namespace Tetris
{
    internal class Program
    {
        static int xOfBlock = 3;
        static int yOfBlock = 1;
        static char[,] LayerWithBlockNow;
        static char[,] LayerBackGroundNow;
        static DateTime TimeLastDown = DateTime.Now;
        static DateTime TimeLastRender = DateTime.Now;
        static DateTime TimeLastButtonManager = DateTime.Now;
        static DateTime TimeLastCheckingStatusOfBlock = DateTime.Now;
        static DateTime TimeLastUpdateLayerWithBlock = DateTime.Now;
        static double TimeOfDown = 1;
        static double TimeOfRender = 0.1;
        static double TimeOfButtonManager = 0.01;
        static double TimeUpdateLayerWithBlock = 0.01;
        static double TimeCheckingStatusOfBlock = 0.01;

        static char[,] EmptyLayerWithBlock = new char[,]
    {
        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },

        { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' }
    };

        static char[,] EmptyLayerBackGround = new char[,]
    {
        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|' },

        { '|', '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|','|' },

        { '|', '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|','|' }


    };
        static char[,] block = new char[,]
        {
        { '#', '#', ' ' },

        { '#', ' ', ' ' },

        { '#', ' ', ' ' }
        };

        static void Main(string[] args)
        {
            LayerBackGroundNow = CopyLayer(EmptyLayerBackGround);
            LayerWithBlockNow = GetNewLayerWithBlock(block, xOfBlock, yOfBlock);

            while (true)
            {
                ControlBlockNow();
            }
        }


        static void ControlBlockNow()
        {
            if ((DateTime.Now - TimeLastDown).TotalSeconds >= TimeOfDown)
            {
                yOfBlock++;
                TimeLastDown = DateTime.Now;
            }
            if ((DateTime.Now - TimeLastButtonManager).TotalSeconds >= TimeOfButtonManager)
            {
                ButtonManager();

                LayerWithBlockNow = GetNewLayerWithBlock(block, xOfBlock, yOfBlock);
                FixBlockThatGoneBehindBorders(LayerWithBlockNow);
                TimeLastButtonManager = DateTime.Now;
            }


            if ((DateTime.Now - TimeLastUpdateLayerWithBlock).TotalSeconds >= TimeUpdateLayerWithBlock)
            {
                LayerWithBlockNow = GetNewLayerWithBlock(block, xOfBlock, yOfBlock);
                TimeLastUpdateLayerWithBlock = DateTime.Now;
            }



            if ((DateTime.Now - TimeLastCheckingStatusOfBlock).TotalSeconds >= TimeCheckingStatusOfBlock)
            {
                if (IfBlockShouldStop(LayerWithBlockNow, LayerBackGroundNow))
                {
                    LayerBackGroundNow = JoinBackAndBlock(LayerWithBlockNow, LayerBackGroundNow);
                    block = GetNewRandomBlock();
                    xOfBlock = 3;
                    yOfBlock = 0;
                }

                int LevelThatNeedDelete = FindAssembledRow(LayerBackGroundNow);
                if (LevelThatNeedDelete >= 0)
                {
                    LayerBackGroundNow = DeletLevelFormBackGround(LayerBackGroundNow, LevelThatNeedDelete);
                }
                TimeLastCheckingStatusOfBlock = DateTime.Now;
            }

            //LayerBackGroundNow = EmptyLayerBackGround;//Затычка!!!!!
            if ((DateTime.Now - TimeLastRender).TotalSeconds >= TimeOfRender)
            {
                WriteBothLayers(LayerWithBlockNow, LayerBackGroundNow);
                TimeLastRender = DateTime.Now;
            }

        }

        //Работат
        static char[,] GetNewLayerWithBlock(char[,] block, int x, int y /*координаты левого верх угла*/)
        {
            char[,] NewEmptyLayerWithNewBlock = CopyLayer(EmptyLayerWithBlock);

            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    NewEmptyLayerWithNewBlock[i, j] = block[i - y, j - x];
                }
            }
            return NewEmptyLayerWithNewBlock;
        }

        //Работат
        static char[,] CopyLayer(char[,] source)
        {
            char[,] newLayer = new char[30, 13];
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    newLayer[i, j] = source[i, j];
                }
            }
            return newLayer;
        }

        //Работат
        static void WriteLayer(char[,] layer)
        {

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(layer[i, j]);
                }
                Console.WriteLine();
            }
        }


        //Работает
        static void WriteBothLayers(char[,] layerWithBlock, char[,] layerBackGround)
        {

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (layerBackGround[i, j] == '_' || layerBackGround[i, j] == '|')
                        Console.Write(layerBackGround[i, j]);
                    else
                    {
                        if (layerWithBlock[i, j] == ' ' && layerBackGround[i, j] == ' ')
                            Console.Write(' ');
                        else
                            Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
        //Работат
        static char[,] JoinBackAndBlock(char[,] layerWithBlock, char[,] layerBackGround)
        {
            char[,] newLayerBackGround = new char[30, 13];
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (layerBackGround[i, j] == '_' || layerBackGround[i, j] == '|')
                        newLayerBackGround[i, j] = layerBackGround[i, j];
                    else
                    {
                        if (layerWithBlock[i, j] == ' ' && layerBackGround[i, j] == ' ')
                            newLayerBackGround[i, j] = ' ';
                        else
                            newLayerBackGround[i, j] = '#';
                    }
                }
            }
            return newLayerBackGround;
        }
        //Работат
        static bool IfBlockShouldStop(char[,] layerWithBlock, char[,] layerBackGround)
        {

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (layerWithBlock[i, j] == '#' && layerBackGround[i + 1, j] != ' ')
                        return true;
                }
            }
            return false;

        }
        //Работат
        static bool IfBarrierOnTheRight(char[,] layerWithBlock, char[,] layerBackGround) //Проверка преграды справа
        {

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (layerWithBlock[i, j] == '#' && (layerBackGround[i, j + 1] == '|' || layerBackGround[i, j + 1] == '#'))
                        return true;
                }
            }
            return false;

        }
        //Работат
        static bool IfBarrierOnTheLeft(char[,] layerWithBlock, char[,] layerBackGround) //Проверка преграды справа
        {

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (layerWithBlock[i, j] == '#' && (layerBackGround[i, j - 1] == '|' || layerBackGround[i, j - 1] == '#'))
                        return true;
                }
            }
            return false;

        }





        //Работат
        static void ButtonManager()
        {

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        if (!IfBarrierOnTheLeft(LayerWithBlockNow, LayerBackGroundNow))
                            xOfBlock -= 1;
                        break;

                    case ConsoleKey.D:
                        if (!IfBarrierOnTheRight(LayerWithBlockNow, LayerBackGroundNow))
                            xOfBlock += 1;
                        break;
                    case ConsoleKey.S:
                        yOfBlock += 1;
                        break;

                    case ConsoleKey.Spacebar:
                        block = GetTurnedBlock(block);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Выход из программы");
                        break;
                }
            }

        }

        //Работат
        static char[,] GetTurnedBlock(char[,] block)
        {
            char[,] newBlock = new char[3, 3];
            newBlock[0, 0] = block[2, 0];
            newBlock[1, 0] = block[2, 1];
            newBlock[2, 0] = block[2, 2];
            newBlock[0, 1] = block[1, 0];
            newBlock[1, 1] = block[1, 1];
            newBlock[2, 1] = block[1, 2];
            newBlock[0, 2] = block[0, 0];
            newBlock[1, 2] = block[0, 1];
            newBlock[2, 2] = block[0, 2];
            return newBlock;
        }


        //Работат
        static bool CheckIfWentBehindRight(char[,] layerWithBlock)
        {
            int j = 11;
            for (int i = 0; i < 30; i++)
            {
                if (layerWithBlock[i, j] == '#')
                    return true;

            }
            return false;
        }

        //Работат
        static bool CheckIfWentBehindLeft(char[,] layerWithBlock)
        {
            int j = 1;
            for (int i = 0; i < 30; i++)
            {
                if (layerWithBlock[i, j] == '#')
                    return true;

            }
            return false;
        }

        //Работат
        static void FixBlockThatGoneBehindBorders(char[,] layerWithBlock)
        {
            while (CheckIfWentBehindLeft(layerWithBlock) || CheckIfWentBehindRight(layerWithBlock))
            {
                if (CheckIfWentBehindLeft(layerWithBlock))
                {
                    xOfBlock += 1;
                }
                else if (CheckIfWentBehindRight(layerWithBlock))
                {
                    xOfBlock -= 1;
                }
                LayerWithBlockNow = GetNewLayerWithBlock(block, xOfBlock, yOfBlock);
                layerWithBlock = LayerWithBlockNow;
            }
        }

        //Работат
        static char[,] DeletLevelFormBackGround(char[,] layerBackGround, int Level)
        {
            char[,] newLayerBackGround = CopyLayer(LayerBackGroundNow);
            for (int i = Level; i > 0; i--)
            {
                for (int j = 0; j < 13; j++)
                {
                    newLayerBackGround[i, j] = layerBackGround[i - 1, j];
                }
            }
            for (int j = 0; j < 13; j++)
            {
                newLayerBackGround[0, j] = ' ';
            }
            newLayerBackGround[0, 0] = '|';
            newLayerBackGround[0, 12] = '|';
            WriteLayer(newLayerBackGround);
            return newLayerBackGround;
        }
        //Работает
        static int FindAssembledRow(char[,] layerBackGround)
        {
            int countOfChar = 0;
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (layerBackGround[i, j] == '#')
                        countOfChar += 1;
                    if (countOfChar == 9)
                    {

                        return i;
                    }
                }
                countOfChar = 0;
            }
            return -1;
        }


        static char[,] GetNewRandomBlock()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5); //
            switch (randomNumber)
            {
                case 0:
                    return new char[,]
                    {
                   { '#', '#', ' ' },

                   { '#', ' ', ' ' },

                   { '#', ' ', ' ' }
                    };
                case 1:
                    return new char[,]
                    {
                   { '#', ' ', ' ' },

                   { '#', ' ', ' ' },

                   { '#', ' ', ' ' }
                    };
                case 2:
                    return new char[,]
                    {
                   { ' ', '#', '#' },

                   { ' ', ' ', '#' },

                   { ' ', ' ', '#' }
                    };
                case 3:
                    return new char[,]
                    {
                   { ' ', ' ', ' ' },

                   { ' ', '#', '#' },

                   { ' ', '#', '#' }
                    };
                case 4:
                    return new char[,]
                    {
                   { ' ', ' ', ' ' },

                   { ' ', '#', ' ' },

                   { '#', '#', '#' }
                    };
                default:
                    return new char[,]
                    {
                   { ' ', '#', ' ' },

                   { '#', '#', '#' },

                   { ' ', '#', ' ' }
                    };
            }
        }

    }
}