(window.webpackJsonp=window.webpackJsonp||[]).push([[19],{90:function(e,t,a){"use strict";a.r(t),a.d(t,"frontMatter",(function(){return s})),a.d(t,"metadata",(function(){return l})),a.d(t,"toc",(function(){return c})),a.d(t,"default",(function(){return b}));var n=a(3),r=a(7),o=(a(0),a(105)),s={slug:"7-0-release",title:"7.0.38 Release - Model type fixes",author:"Dan Jagnow",author_title:"Maintainer",author_url:"https://github.com/danjagnow",author_image_url:"https://avatars.githubusercontent.com/u/1059973?s=400&v=4",tags:["releases"]},l={permalink:"/warcraft/blog/7-0-release",editUrl:"https://github.com/blizzard-net/warcraft/edit/documentation/blog/blog/2021-07-20-7-0-release.md",source:"@site/blog/2021-07-20-7-0-release.md",description:"Today we published release 7.0.38 of ArgentPonyWarcraftClient and ArgentPonyWarcraftClient.Extensions.DependencyInjection.",date:"2021-07-20T00:00:00.000Z",formattedDate:"July 20, 2021",tags:[{label:"releases",permalink:"/warcraft/blog/tags/releases"}],title:"7.0.38 Release - Model type fixes",readingTime:.875,truncated:!1,nextItem:{title:"New Docs",permalink:"/warcraft/blog/new-docs"}},c=[],i={toc:c};function b(e){var t=e.components,a=Object(r.a)(e,["components"]);return Object(o.b)("wrapper",Object(n.a)({},i,a,{components:t,mdxType:"MDXLayout"}),Object(o.b)("p",null,"Today we published release 7.0.38 of ",Object(o.b)("a",{parentName:"p",href:"https://www.nuget.org/packages/ArgentPonyWarcraftClient/7.0.38"},"ArgentPonyWarcraftClient")," and ",Object(o.b)("a",{parentName:"p",href:"https://www.nuget.org/packages/ArgentPonyWarcraftClient.Extensions.DependencyInjection/7.0.38"},"ArgentPonyWarcraftClient.Extensions.DependencyInjection"),".\nThis release includes a number of changes to model types for the ",Object(o.b)("a",{parentName:"p",href:"https://develop.battle.net/documentation/world-of-warcraft/game-data-apis"},"Game Data APIs")," to more accurately reflect the structure of the JSON data returned from the Blizzard APIs.\nMost of the changes are small, but they are breaking changes.\nUpgrade with caution."),Object(o.b)("p",null,"The following APIs are impacted:"),Object(o.b)("ul",null,Object(o.b)("li",{parentName:"ul"},"Creature API"),Object(o.b)("li",{parentName:"ul"},"Guild Crest API"),Object(o.b)("li",{parentName:"ul"},"Item API"),Object(o.b)("li",{parentName:"ul"},"Journal API"),Object(o.b)("li",{parentName:"ul"},"Mount API"),Object(o.b)("li",{parentName:"ul"},"Mythic Raid Leaderboard API"),Object(o.b)("li",{parentName:"ul"},"Pet API"),Object(o.b)("li",{parentName:"ul"},"Profession API"),Object(o.b)("li",{parentName:"ul"},"Quest API"),Object(o.b)("li",{parentName:"ul"},"Tech Talent API")),Object(o.b)("p",null,"The ",Object(o.b)("strong",{parentName:"p"},"System.Text.Json")," dependency has also been updated from 5.0.1 to ",Object(o.b)("a",{parentName:"p",href:"https://www.nuget.org/packages/System.Text.Json/5.0.2"},"5.0.2")," with this release."),Object(o.b)("p",null,"See the ",Object(o.b)("a",{parentName:"p",href:"https://github.com/blizzard-net/warcraft/releases/tag/v7.0.38"},"7.0.38 release notes")," for full details about the changes."),Object(o.b)("p",null,"This release also included changes behind the scenes to perform deep comparisons for integration tests that use live data from the Blizzard APIs.\nIn the future, this should make it easier to detect changes to the response data structure as Blizzard makes changes to the APIs over time.\nThis is an extension of work by ",Object(o.b)("a",{parentName:"p",href:"https://github.com/willwolfram18"},"willwolfram18")," in ",Object(o.b)("a",{parentName:"p",href:"https://github.com/blizzard-net/warcraft/pull/166"},"#166"),"."))}b.isMDXComponent=!0}}]);