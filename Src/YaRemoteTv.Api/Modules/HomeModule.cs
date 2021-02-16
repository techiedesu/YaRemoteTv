using Carter;
using Carter.ModelBinding;
using Microsoft.AspNetCore.Http;
using YaRemoteTv.Api.Models;

namespace YaRemoteTv.Api.Modules
{
    public class HomeModule : CarterModule
    {
        public HomeModule()
        {
            Post("/", async (req, res) =>
            {
                var requestModel = await req.Bind<YandexApiRequestModel>();

                await res.WriteAsJsonAsync(new YandexApiResponseModel
                {
                    Response = new Response
                    {
                        Text = requestModel.Request.Command,
                        Tts = requestModel.Request.Command,
                        EndSession = false,
                    },

                    Version = "1.0",
                });
            });
        }
    }
}