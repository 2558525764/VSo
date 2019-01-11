using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Weather
    {
  //      "result":{
		//"sk":{
		//	"temp":"7",
		//	"wind_direction":"东北风",
		//	"wind_strength":"1级",
		//	"humidity":"98%",
		//	"time":"08:40"
		//},
		//"today":{
		//	"temperature":"6℃~9℃",
		//	"weather":"小雨",
		//	"weather_id":{
		//		"fa":"07",
		//		"fb":"07"
		//	},
		//	"wind":"东北风微风",
		//	"week":"星期五",
		//	"city":"上海",
		//	"date_y":"2019年01月11日",
		//	"dressing_index":"较冷",
		//	"dressing_advice":"建议着厚外套加毛衣等服装。年老体弱者宜着大衣、呢外套加羊毛衫。",
		//	"uv_index":"最弱",
		//	"comfort_index":"",
		//	"wash_index":"不宜",
		//	"travel_index":"较不宜",
		//	"exercise_index":"较不宜",
		//	"drying_index":""
		//},

        [DisplayName("温度")]
        //	"temperature":"6℃~9℃",
        public string Temperature { get; set; }



        [DisplayName("城市")]
        //city：柳州
        public string City { get; set; }

        [DisplayName("湿度")]

        public string Humidity { get; set; }

        [DisplayName("风向")]
        public string Wind_direction { get; set; }
    }
}