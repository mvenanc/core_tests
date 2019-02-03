﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace WebAPIClient {

    class Program {
        private static async Task<List<Repository>> ProcessRepositories () {
            client.DefaultRequestHeaders.Accept.Clear ();
            client.DefaultRequestHeaders.Accept.Add (
                new MediaTypeWithQualityHeaderValue ("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add ("User-Agent", ".NET Foundation Repository Reporter");
            var serializer = new DataContractJsonSerializer (typeof (List<Repository>));
            //var stringTask = client.GetStringAsync ("https://api.github.com/orgs/dotnet/repos");
            var streamTask = client.GetStreamAsync ("https://api.github.com/orgs/dotnet/repos");
            //var repositories = serializer.ReadObject (await streamTask) as List<Repository>;
            var repositories = serializer.ReadObject (await streamTask) as List<Repository>;
            return repositories;
            //var msg = await stringTask;
            //Console.Write (msg);
            //foreach (var repo in repositories)
            //    Console.WriteLine (repo.Name);
        }

        private static readonly HttpClient client = new HttpClient ();
        static void Main (string[] args) {

            var repositories = ProcessRepositories ().Result;

            foreach (var repo in repositories) {
                Console.WriteLine (repo.Name);
                Console.WriteLine (repo.Description);
                Console.WriteLine (repo.GitHubHomeUrl);
                Console.WriteLine (repo.Homepage);
                Console.WriteLine (repo.Watchers);
                Console.WriteLine (repo.LastPush);
                Console.WriteLine ();
            }

        }
    }
}