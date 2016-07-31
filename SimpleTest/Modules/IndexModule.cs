using Nancy;
using System;

namespace SimpleTest.Modules
{
    public class IndexModule : NancyModule
    {

        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Get["/loaderio-1fe0a92fa02d5933569d50dcdb1adf4d.txt"] = parameters =>
            {
                return "loaderio-1fe0a92fa02d5933569d50dcdb1adf4d";
            };

            Get["/api/loadtest"] = parameters =>
            {
                var test = new SimpleObject()
                {
                    now = DateTime.Now.ToLongDateString(),
                    guid = Guid.NewGuid().ToString(),
                    data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris laoreet venenatis ipsum. Proin malesuada eget turpis non fermentum. Nam blandit mi gravida odio malesuada, sed vulputate ipsum aliquet. Sed vitae blandit est. Ut a risus at ex dictum tristique eget eu arcu. In commodo gravida arcu, auctor pulvinar nulla accumsan non. Phasellus nisl nibh, semper eu molestie ut, malesuada eu libero. Integer suscipit laoreet diam, sit amet ultricies leo ullamcorper eget. In imperdiet a sem non accumsan.Vivamus gravida feugiat tristique. Proin in luctus ipsum. Nullam iaculis dapibus purus eget mattis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam erat volutpat. Cras bibendum eget enim vitae vehicula. Phasellus et est lorem. Mauris eros ipsum, laoreet sit amet tincidunt id, finibus ac lacus. Nullam iaculis nisl vitae nibh viverra volutpat. Mauris luctus lectus eu turpis dictum, a interdum nisi porttitor. Mauris vel feugiat ligula.Etiam semper at leo a aliquet. Aenean auctor tincidunt cursus. Donec ullamcorper accumsan maximus. Nam sit amet urna nec nulla pulvinar interdum sit amet vitae diam. Cras sagittis lorem vitae dapibus convallis. In ligula augue, placerat ac aliquet vitae, laoreet quis ante. Integer neque odio, tincidunt sodales vestibulum nec, auctor vel libero. Aliquam maximus molestie quam eu vestibulum. Vivamus imperdiet magna a metus consequat, non condimentum ex volutpat. Aenean elit mauris, consectetur non magna id, malesuada varius dolor. Cras at venenatis risus. Praesent luctus nisi ut tellus lacinia, sit amet pulvinar libero dictum. In consequat ante ligula, id lacinia eros maximus vel. Mauris imperdiet aliquam diam ut tincidunt. Donec cursus a risus vel tempus.Cras eu varius sem. Etiam blandit porttitor magna, quis varius mauris fringilla non. In aliquet tellus et lacus elementum, quis iaculis mi sagittis. Aenean dapibus laoreet lorem, et consectetur lectus dignissim eu. Mauris semper, dolor non porttitor maximus, nulla magna sodales metus, at vulputate quam elit sit amet urna. Praesent a neque sed quam ultrices ullamcorper. Phasellus vehicula arcu vitae dolor dapibus, sed suscipit quam suscipit. Quisque fringilla eros nibh. Sed eleifend pharetra ligula non aliquam.Vestibulum a arcu turpis. In sapien nunc, malesuada ac gravida id, aliquam id enim. Quisque eleifend varius erat, sit amet euismod nulla lacinia in. Aenean et feugiat tellus. Quisque elit magna, aliquet a finibus eget, imperdiet ac ipsum. Maecenas maximus libero eget sapien lobortis scelerisque. Pellentesque tristique quam enim, ut vehicula lectus vulputate vitae. Sed euismod id massa a aliquam. Proin fringilla ante ut sem ultricies imperdiet. Sed accumsan finibus ullamcorper. In odio lectus, cursus nec tempus ac, ultricies ac quam. Sed pharetra sapien ac urna finibus, non vehicula enim feugiat. Praesent hendrerit ligula eget felis pretium, id hendrerit elit mattis.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris laoreet venenatis ipsum. Proin malesuada eget turpis non fermentum. Nam blandit mi gravida odio malesuada, sed vulputate ipsum aliquet. Sed vitae blandit est. Ut a risus at ex dictum tristique eget eu arcu. In commodo gravida arcu, auctor pulvinar nulla accumsan non. Phasellus nisl nibh, semper eu molestie ut, malesuada eu libero. Integer suscipit laoreet diam, sit amet ultricies leo ullamcorper eget. In imperdiet a sem non accumsan.Vivamus gravida feugiat tristique. Proin in luctus ipsum. Nullam iaculis dapibus purus eget mattis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam erat volutpat. Cras bibendum eget enim vitae vehicula. Phasellus et est lorem. Mauris eros ipsum, laoreet sit amet tincidunt id, finibus ac lacus. Nullam iaculis nisl vitae nibh viverra volutpat. Mauris luctus lectus eu turpis dictum, a interdum nisi porttitor. Mauris vel feugiat ligula.Etiam semper at leo a aliquet. Aenean auctor tincidunt cursus. Donec ullamcorper accumsan maximus. Nam sit amet urna nec nulla pulvinar interdum sit amet vitae diam. Cras sagittis lorem vitae dapibus convallis. In ligula augue, placerat ac aliquet vitae, laoreet quis ante. Integer neque odio, tincidunt sodales vestibulum nec, auctor vel libero. Aliquam maximus molestie quam eu vestibulum. Vivamus imperdiet magna a metus consequat, non condimentum ex volutpat. Aenean elit mauris, consectetur non magna id, malesuada varius dolor. Cras at venenatis risus. Praesent luctus nisi ut tellus lacinia, sit amet pulvinar libero dictum. In consequat ante ligula, id lacinia eros maximus vel. Mauris imperdiet aliquam diam ut tincidunt. Donec cursus a risus vel tempus.Cras eu varius sem. Etiam blandit porttitor magna, quis varius mauris fringilla non. In aliquet tellus et lacus elementum, quis iaculis mi sagittis. Aenean dapibus laoreet lorem, et consectetur lectus dignissim eu. Mauris semper, dolor non porttitor maximus, nulla magna sodales metus, at vulputate quam elit sit amet urna. Praesent a neque sed quam ultrices ullamcorper. Phasellus vehicula arcu vitae dolor dapibus, sed suscipit quam suscipit. Quisque fringilla eros nibh. Sed eleifend pharetra ligula non aliquam.Vestibulum a arcu turpis. In sapien nunc, malesuada ac gravida id, aliquam id enim. Quisque eleifend varius erat, sit amet euismod nulla lacinia in. Aenean et feugiat tellus. Quisque elit magna, aliquet a finibus eget, imperdiet ac ipsum. Maecenas maximus libero eget sapien lobortis scelerisque. Pellentesque tristique quam enim, ut vehicula lectus vulputate vitae. Sed euismod id massa a aliquam. Proin fringilla ante ut sem ultricies imperdiet. Sed accumsan finibus ullamcorper. In odio lectus, cursus nec tempus ac, ultricies ac quam. Sed pharetra sapien ac urna finibus, non vehicula enim feugiat. Praesent hendrerit ligula eget felis pretium, id hendrerit elit mattis."
                };

                return Response.AsJson(test);
            };
        }
    }

    public class SimpleObject
    {
        public string data { get; set; }
        public string now { get; set; }
        public string guid { get; set; }
    }
}