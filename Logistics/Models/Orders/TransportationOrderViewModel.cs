using System;
using System.Collections.Generic;
using Antlr.Runtime.Misc;
using Logistics.Models.Load;

namespace Logistics.Models.Orders
{
    public class TransportationOrderViewModel
    {
        public List<LoadViewModel> Loads { get; set; }

        public List<UnLoadViewModel> UnLoads { get; set; }

        public List<OrderCommentViewModel> Comments { get; set; }

        public OrderSummaryViewModel Summary { get; set; }

        public TransportationOrderViewModel()
        {
            Comments = new List<OrderCommentViewModel>();
            Summary = new OrderSummaryViewModel();
            UnLoads = new List<UnLoadViewModel>();
            Loads = new List<LoadViewModel>();
        }



        public static TransportationOrderViewModel CreateTestViewModel()
        {
            return new TransportationOrderViewModel()
            {
                Summary = new OrderSummaryViewModel
                {
                    OrderStatus = "Новая",
                    OrderNumber = "3424-08",
                    CreateDate = DateTime.Today.AddDays(-4),
                    OrganizationName = "ТОВ 'Альфа транс груп'",
                    ContactPersonName = "Данилевский Н.Д",
                    ContactPersonPhone = "+38 093 456 3455",
                    OrderpPriceUsd = "2000.00",
                    OrderpPriceUah = "52000.00",
                    NbuRateDate = DateTime.Today.AddDays(-4).ToString("d"),
                    ContractNumber = "LO-2345",
                    PaymentStatus = "Не Оплачена"
                },

                Comments = new List<OrderCommentViewModel>
            {
                new OrderCommentViewModel("Борсучок О.П", DateTime.Today.AddDays(-1)),
                new OrderCommentViewModel("Борсучок О.П", DateTime.Today.AddDays(-2)),
                new OrderCommentViewModel("Борсучок О.П", DateTime.Today.AddDays(-3))
            },
                UnLoads = new List<UnLoadViewModel>
                {
#region UnLoad1
		                    new UnLoadViewModel
                    {
                        UnLoadOrder = 1,
                        PlannedLoadingDate = DateTime.Today.AddDays(1),
                        CargoList = new List<CargoViewModel>

                            {
                            new CargoViewModel
                            {
                                Description = "Мешки с цементом",
                                Packaging = "Без палеты",
                                WeightKg = 2400,
                                VolumeMCube = 4.50 ,
                                LoadedQuantity = 20,
                                LoadingKind = "Задняя",
                                ClassificationList =  new List<CargoClassificationViewModel>
                                {
                                    new CargoClassificationViewModel()
                                    {Code ="Грязный",
                                    Description =""
                                    }
                                }
                            },
                            new CargoViewModel
                            {
                                Description = "Крановые блоки",
                                WeightKg = 6400,
                                VolumeMCube = 2.50 ,
                                LoadedQuantity = 10,
                                LoadingKind = "Задняя",
                                ClassificationList =  new List<CargoClassificationViewModel>
                                {
                                    new CargoClassificationViewModel()
                                    {Code ="Опасный",
                                    Description ="Класс 444"
                                    },
                                    new CargoClassificationViewModel()
                                    {Code ="Ценный",
                                    Description ="2345 EUR"
                                    },
                                   new CargoClassificationViewModel()
                                    {Code ="Негабарит",
                                    Description ="(H=2 W=1 L=15)"
                                    }
                                }
                            },

                         }
                    }, 
	#endregion
#region UnLoad2
		                    new UnLoadViewModel
                    {
                        UnLoadOrder = 2,
                        PlannedLoadingDate = DateTime.Today.AddDays(1),
                        CargoList = new List<CargoViewModel>
                            {
                            new CargoViewModel
                            {
                                Description = "Мешки с Сахаром",
                                Packaging = "без палеты",
                                WeightKg = 3500,
                                VolumeMCube = 3.50 ,
                                LoadedQuantity = 20,
                                LoadingKind = "Задняя",
                                ClassificationList =  new List<CargoClassificationViewModel>
                                {
                                    new CargoClassificationViewModel()
                                    {Code ="Чистый",
                                    Description =""
                                    }
                                }
                            },

                         }
                    } 
	#endregion
                },
                Loads = new List<LoadViewModel>
                {
#region Load1
		                    new LoadViewModel
                    {
                        DeliveryAddress = "ул.Соборная 4, Винница",
                        LoadOrder = 1,
                        Sender = "ТОВ 'Винпромаш'",
                        ContactPersonName =  "Данилевский Н.Д",
                        ContactPersonPhone =  "+38 093 456 7234",
                        PlannedLoadingDate = DateTime.Today.AddDays(1),
                        Receiver = "Инвойтс",
                        CargoList = new List<CargoViewModel>
                            {
                            new CargoViewModel
                            {
                                Description = "Мешки с цементом",
                                Packaging = "Без палеты",
                                WeightKg = 2400,
                                VolumeMCube = 4.50 ,
                                LoadedQuantity = 20,
                                LoadingKind = "Задняя",
                                ClassificationList =  new List<CargoClassificationViewModel>
                                {
                                    new CargoClassificationViewModel()
                                    {Code ="Грязный",
                                    Description =""
                                    }
                                }
                            },
                             new CargoViewModel
                            {
                                Description = "Крановые блоки",
                                WeightKg = 6400,
                                VolumeMCube = 2.50 ,
                                LoadedQuantity = 10,
                                LoadingKind = "Задняя",
                                ClassificationList =  new List<CargoClassificationViewModel>
                                {
                                    new CargoClassificationViewModel()
                                    {Code ="Опасный",
                                    Description ="Класс 444"
                                    },
                                    new CargoClassificationViewModel()
                                    {Code ="Ценный",
                                    Description ="2345 EUR"
                                    },
                                   new CargoClassificationViewModel()
                                    {Code ="Негабарит",
                                    Description ="(H=2 W=1 L=15)"
                                    }
                                }
                            },

                         }
                    }, 
	#endregion
#region Load2
		                    new LoadViewModel
                    {
                        DeliveryAddress = "ул.Соборная 4, Винница",
                        LoadOrder = 2,
                        Sender = "ТОВ 'Винпромаш'",
                        ContactPersonName =  "Данилевский Н.Д",
                        ContactPersonPhone =  "+38 093 456 7234",
                        PlannedLoadingDate = DateTime.Today.AddDays(1),
                        Receiver = "Инвойтс",
                        CargoList = new List<CargoViewModel>
                            {
                            new CargoViewModel
                            {
                                Description = "Мешки с Сахаром",
                                Packaging = "без палеты",
                                WeightKg = 3500,
                                VolumeMCube = 3.50 ,
                                LoadedQuantity = 20,
                                LoadingKind = "Задняя",
                                ClassificationList =  new List<CargoClassificationViewModel>
                                {
                                    new CargoClassificationViewModel()
                                    {Code ="Чистый",
                                    Description =""
                                    }
                                }
                            },

                         }
                    } 
	#endregion
                }

            };

        }
    }
}