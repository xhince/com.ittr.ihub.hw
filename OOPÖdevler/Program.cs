using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPÖdevler
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class glass
    {
        private int width;
        private int height;
        private int capacity;
        private int shape;
        private int productLife;
        private string productName;
        private int productId;
        private int productMaterialId;
        private int factoryId;//Yapıldığı fabrikanın id'si
        private int productSetId;
        public int getWidth()
        {
            return width;
        }
        public void setWidth(int Width)
        {
            width = Width;
        }
        public int getHeight()
        {
            return height;
        }
        public void setHeight(int Height)
        {
            height = Height;
        }
        public void setCapacity(int Capacity)
        {
            capacity = Capacity;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public int getShape()
        {
            return shape;
        }
        public void setShape(int Shape)
        {
            shape = Shape;
        }
        public int getProductLife()
        {
            return productLife;
        }
        public void setProductLife(int ProductLife)
        {
            productLife = ProductLife;
        }
        public string getProductName()
        {
            return productName;
        }
        public void setProductName(string ProductName)
        {
            productName = ProductName;
        }
        public int getProductId()
        {
            return productId;
        }
        public void setProductId(int ProductId)
        {
            productId = ProductId;
        }
        public int getFactoryId()
        {
            return factoryId;
        }
        public void setFactoryId(int FactoryId)
        {
            factoryId = FactoryId;
        }
        public int getProductMaterialId()
        {
            return productMaterialId;
        }
        public void setProductMaterialId(int ProductMaterialId)
        {
            productMaterialId = ProductMaterialId;
        }
        public int getProductSetId()
        {
            return productSetId;
        }
        public void setProductSetId(int ProductSetId)
        {
            productSetId = ProductSetId;
        }
        glass(int Width, int Height)
        {
            setWidth(Width);
            setHeight(Height);
            setCapacity(Width * Height);
            if(getCapacity() < 100)
            {
                setShape(1);//1 küçük boyutta olduğunu gösteriyor.
                setProductLife(1);//küçük boyutta olan bardakların yıllık ömrü
            }
            else
            {
                setShape(2);
                setProductLife(2);
            }
        }
    }
   
}
