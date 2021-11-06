using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuz.Lab03.Task03.ClassLib
{
	public abstract class Device
	{
		public abstract void SwitchOn();
		public abstract void SwitchOff();
		protected string m_brand;
		protected string m_model;
		protected bool m_state;

	}
	public class Iron : Device
	{
		private Steam m_steam;
		private Temperature m_temp;
		public override void SwitchOn()
		{
			m_state = true;
			Console.WriteLine("Девайс работает\n");
		}
		public override void SwitchOff()
		{
			m_state = false;
			Console.WriteLine("Девайс выключен\n");
		}

		public void Print()
		{
			Console.WriteLine("\nБренд: {0},\nМодель: {1},\nТемпература: {2},\nПар: {3}\n", m_brand, m_model, m_temp, m_steam);
		}

		public Iron()
		{
			m_temp = Temperature.Low;
			m_steam = Steam.Supply;
			m_brand = "NoName";
			m_model = "Unknown";
		}

		public Iron(string brand)
		{
			m_temp = Temperature.Low;
			m_steam = Steam.Supply;
			m_brand = brand;
			m_model = "Unknown";
		}

		public Iron(string brand, string model)
		{
			m_temp = Temperature.Low;
			m_steam = Steam.Supply;
			m_brand = brand;
			m_model = model;
		}

		public void NextTemperature()
		{
			if (m_state)
			{
				if (m_temp == Temperature.Low)
			{
				m_temp = Temperature.Middle;
				Console.Write("Средняя температура");
			}
			else if (m_temp == Temperature.Middle)
			{
				m_temp = Temperature.High;
				Console.Write("Высокая температура");
			}
			else
				Console.Write("Температура не может быть выше");
		}
			else
				Console.Write("Утюг выключен\n");
		}

		public void PrevTemperature()
		{
			if (m_state)
			{
				if (m_temp == Temperature.High)
				{
					m_temp = Temperature.Middle;
					Console.Write("Средняя температура\n");
				}
				else if (m_temp == Temperature.Middle)
				{
					m_temp = Temperature.Low;
					Console.Write("Низкая температура\n");
				}
				else
					Console.Write("Температура не может быть ниже\n");
			}
			else
				Console.Write("Утюг выключен\n");
		}

		public void SupplySteam()
		{
			if (m_state)
			{
				m_steam = Steam.Supply;
			}
			else
				Console.Write("Утюг выключен\n");
		}

		public void HitSteam()
		{
			if (m_state)
			{
				m_steam = Steam.Hit;
			}
			else
				Console.Write("Утюг выключен\n");
		}

		public void SelfCleaningSteam()
		{
			if (m_state)
			{
				m_steam = Steam.SelfCleaning;
			}
			else
				Console.Write("Утюг выключен\n");
		}

		public void SteamingSteam()
		{
			if (m_state)
			{
				m_steam = Steam.Steaming;
			}
			else
				Console.Write("Утюг выключен\n");
		}
	}
	public class TV : Device
	{
		private float m_diagonal;
		private Resolution m_resolution;
		public override void SwitchOn()
		{
			m_state = true;
			Console.WriteLine("TV работает\n");
		}
		public override void SwitchOff()
		{
			m_state = false;
			Console.WriteLine("TV выключен\n");
		}
		public void Print()
		{
			Console.WriteLine("\nБренд: {0},\nМодель: {1},\nДиагональ: {2},\nРазрешение: {3}\n", m_brand, m_model, m_diagonal, m_resolution);
		}
		public TV()
		{
			m_diagonal = 0;
			m_resolution = Resolution.HD;
			m_brand = "NoName";
			m_model = "Unknown";
		}
		public TV(string brand)
		{
			m_diagonal = 0;
			m_resolution = Resolution.HD;
			m_brand = brand;
			m_model = "Unknown";
		}
		public TV(string brand, string model)
		{
			m_diagonal = 0;
			m_resolution = Resolution.HD;
			m_brand = brand;
			m_model = model;
		}
		public void HDresolution()
		{
			if (m_state)
			{
				m_resolution = Resolution.HD;
			}
			else
				Console.Write("TV выключен\n");
		}
		public void UHDresolution()
		{
			if (m_state)
			{
				m_resolution = Resolution.UHD;
			}
			else
				Console.Write("TV выключен\n");
		}
		public void SetDiagonal(float d)
        {
			if(d > 0)
				m_diagonal = d;
			else
				throw new Exception("Ошибка при вводе данных");
		}
	}
}
