﻿
using MusicSmash.Models;

namespace MusicSmash.Services
{
	public class AlbumService
	{
		internal Album[] GetAlbums()
		{
			return new Album[]
			{
				new ()
				{
					Name = "X2VR",
					Cover = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBERERgREREZGBEREhgREhISGBIYEhgRGBgZGRoYGBgcIS4lHB4rIRgYJjomKy8xNTU1GiQ7QDs0Py40NTQBDAwMDw8PGA8PGTQdGB0xNDExMTExNDExMTExNDExMTExMTE0MTExMTExMTExMTExMTExMTExMTExMTExMTExMf/AABEIAOEA4QMBIgACEQEDEQH/xAAcAAEAAgMBAQEAAAAAAAAAAAAAAQUEBgcDAgj/xABEEAACAgECAwYDBQMKBAcBAAABAgADEQQSBSExBhMiQVFhBzJxFCNCgZGhscEzNFJicoKS0eHwFlN0sjWToqOz0vEV/8QAFAEBAAAAAAAAAAAAAAAAAAAAAP/EABQRAQAAAAAAAAAAAAAAAAAAAAD/2gAMAwEAAhEDEQA/AOyyZEmAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiBESZEBERASZEmAiIgIiICIiAiIgIiICIiAiIgIiICIiAiRECYiRAmJEQJkREBERAruDcZ0+srFmnsDKRkjluH1EsZxjXdj9VoG+3cC1Hf6ceI0o4ewL1whXlYuPL5unzdZednfivpbECa7NVwYIcI7ZbpzVQSDn2gdMieVNquodCCjAMrDoQZ6wEREBERAREQEREBESIExEQESIgIiICIiAiIgIiICIiAiIgVmq4DpLXNjUKLSNvfV5rvx6C1CHH6znXbj4aanU6hdVptRuwuHWwVjUeHptcBRa2OQ7xgeQBbHTrEQOFcK7U8R4MVGpBt0bOUWzDbd4+ZGDANXYOeUYBhjoROtdnu0ul4hWHocbsc0JG8fl5ifPG+Ci3dbUiNY6hbqLQO41NY6JaMHDD8L4JX3GROa67sNYpOs4G7o9bYu0FrbbqrAMlQSTz5ggEkEEMrMCsDtETlfZT4nAv9l4ijV3IdjM6lWDDyZTzz+36zp1F6WKHRgytzDKQQYHtERAREp9Zx2pHNNatfqR1o04DMuehsYkLUP7bDPlmBcRNe1XFNXp0Go1NdKUB1W1UtdnRHYIH3sqq2CwJXA5ZwSQAdggIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICVfEOFCxhdU/dapV2rcqghkBJFdqcu8TJPhJBGSVKk5lpEDQu03BtDxACvidX2bV8kq1a4CO3kEuIwwJOO7fDdcD8U0tv/wCv2bfLk3aEsALVyayCcAOvVG6dfXAJnbba1dSrKGVhgqwBUg+RB6iU9nZjSkFVWxKyuw1U36mujaeoFSOEA+gECv4F250WrpNu4oygF6wGd8nAwqqCzEkgYAyfLMsBrdbd/IadaUOQLdYSXPoy0VnJB9GdG9po3aT4WhD9p4O5qtQfzdmYo2B+F2JIJ9GyDnqJVdn/AIpWUgUahS7A7T3u5bK2BwVc48XPPuPyxA6eeDWWfzrWWuCBmunGnpz7d395j2ZyJZaLRVUIK6a1RF6JWoVQTzJwPM+sp9B2u0dqqWtFZfG3vCAhY4GA/wAucnABwT6TYAYGhfGfW91wll/5+oqrx64Jsx/7c3Phlhait26vUjE+5UEzS/itovtNWmoKuVbVbn7tdzKordcnwkAeLqRN50teytEHRUVf0AED2iIgIiICIiAiIgIiICIiAiJECYkRAREQERECYkSYCIiAnIPiR2cbV8Srr+yFBqQipxChbH+9AbK6hFGCPlG7wlV8WWAKjr8iBwThnYviOge19XpbLdOtbAfZXodnKjwgBgzKhyT8oPI5HPBwez/GtZovvtNqXfQsCRSbK0ZSGJ2ip+WfCwPd4yDyIIwP0TNJ7ddlNDdQ9x0yjU2PXUttW5X33WpXvYKyiwjfuw3XEDV7+3er333aREerut6WXjG2qtCMjDeLxiw4/rexE3Xs/wAfs1D1UuymwVGy7apAKgYVxnoGJUjy+Yc8Zn52d2SlCtr/AHodShYqjVAlByzjHUY9zOifDTW2vqRqdRqirChFUOa8Nphe6NWGdDhAfF4WByrdfIO3RPKjUI4yjhh6qQZ6wJiRECZERAmREQEREBERAREQEREBERARIkwERECYkRAmREQE8r0Qqd4yo8Rz7ec9ZicUs2ae1/6FLt+iEwPzr2j1VK1pmoG123g7du1dwY4OOhORy95VW8ZFiCt2dEXwrXWVWsAkseQ8sknHTLGYvF2Heddx2gAs5fAAxjJ8+R6ytDeHb6nMDYNNqrtKyslr7eqOjsrgHy5HI/Z0nSOy/wATLFKV6sh6mZUOoI2um4HG7HzDO3n15nmZx1r3cjnkgDr05e0yarncbAVGRkr0B+nvygfq/R6lLq1sRgyP8rKcg4ODg/UGZE0b4TCw8OV2bwE7KkAxtQZY59WLO3P0C+83iBrXbLtQvDqlKVNdqbSRTQgYk7cbnbAJCjI9ySB7jj3Gu1/GtQd9ld1dfMbK0trrH5jn+ZM6JxDi1z6qxgyipDsTDoWCg4DFBzG45PP1jUcZVRhVUuRjPNcZ6nl1+kDj+n7U3I24O6E8wa3tRsnzLbuc2fhXxS1tJG+xbU5ZS0Evjzw/I5/MyeMcATVWNYz7rHPPpy5e3LHpKZuyOBj5T+En19PaB2zsn2z03ERtQ7NQF3NS5BJHmUP4h+0ek2iflo06nQWLdUxD0urjrkFSGBx5j19jifpnhWsGo09V4GBdUloXrjeobH7YGZEiIExEiBMiIgIiICIiAkyJMBERAREQImDxrTtbpbqkOHtpdFJ6AspX+MzoMD8h8UrdLnrcYdHZGGc4YE+cwyfadI+MfZv7Jql1VanudXkseZVb16jPlkEED2bHSc4xA9HUA+E8h++WN3CLloTUspWuxtlbtkbiM8wPTkf0M+E4ezUNYCTtwcfU4Ofy/fOgPwuvUaSopsfvK60Rq/mWpAVZX/rht/L3HpA3/wCEiWDhSGwDx22sgHXZvI5/mG/LE2XtBc9ekves4ddPYyH+uEO3884mVodMlVSVoMIiBVAx0Amgdp+1yu9unrYK+mdkepztdmBChlQjxg5yOfTnA5P2Z1LValBUCLdxV+TncpPMWLzDKf1HIidA4loLCpJQq3VfMc/LMr+CccTTWMO5Qs7Zazbhsnr+UtOK8fcqSMFD1Hryzj88Ygaxw/V2q+0hmySAgBLdcDAHny/bNj1VoZNjIQw5MrjaysPIg8wf85Rdo6UapO7V3a0qttaBtgqJPja3BCncAMNy5nymVxG2xQE07FkrD1qXYsxr3uUG49cA8vQYHQCBF2y0YdQcDZjHi5np++da7Ipt4fplx8lCIP7KDaP2ATjGia5rNj1c7CFVkHiLnkF+pM7tw/T91SlfmiKhPqQACf1gZMREBERAREQEREBEiIExEQEmRECZERAREou0/aBNFWDgNbZkVVnoSMZZv6oyPrkfUBVfE96G4e+nsAa24r3Kfi3q4Jf2AGefvjznOezvYVLEPecy3n+LH+U9uMa97m3s5a1z4mP7gPID0l72Y4miAhidwgY2o7IWadO7ppd1YYIJU8j15/5zL4H2b1m9au47mn8Tk1kBB1wFJ8RntxbtgKgQFPTlmWvZLjtl6bnGF8s+cDecYnJ/iFxRauJp3tKMEqArcbGZEcEMzfiV93IDmCoyMc51Km0EdfpOa/FXs6lj16mml2vcsl71JY+5FVdu4KDgjGAeXLPtA03WDxDxDoPFhck468gBz68p9JqkGMnp+nkf4Sk1vEEQbDkOnhKvycH6HnK6u+zUWLXXuNljBECBixz1wF5k+XL3gXCcbdq84ZEsstWxyFO+rcjIFXpuUlhvwT8ozyGNlosrsrHdeJcderA+/pKDSdmtRZ9y6OiV2FiLAVcc9p5FRjODyBIzz5ZzOicC4NTWuxawvlyHM/U9TAyewvBd1p1Ni+Go4QH/AJpHX6AH9SPSdAmDwfTiuhEAx1Y/Ukn/AH9JnQEREBIkxASIiBMSIgIiICTIiBMSIgTIiICcV+JvFFt4gUR8rTStfI8t4ZmfH+ID+7Os9otY1GjvuT566LHQ+jBTg/rifmvU3sX3eoIOff8A1xAteG3lnHngGW2iuKXgn5TyzNc4O5Df3P4y7dg6jAxjzgWvam+j7MxLDft5Y6gyg7M9qHrQA/hOD6GVvH3Pd4JlTob7EqdEwO8G0sebbPPA8uo5/pzgdk4N2s3vtNgQnpnmP0m118fQDBsUt6gjnPzqq6hFDA7hnl1z0zyMsNDrNWOSV5ON3Nj7/wCR/SB3q7iOm1A2XVpYp5bbER1/RhMfR6XhtNgenSUVuOQeuutHGfRgMicp0uu4k4yqKo2hsksTtPmBjn6S3XgXF7AH+1V7WXfuAPJcZBBJ6YgdbS5G6bTnn5EzyCoXblzAwSAoAPuAeR+oE45pKeMVPmqw2nbvwoJwoPmRlc+03rs81tlhvurRw1YK2VpbWzMwyyWVAYZlABJYEjw4POBtuk4lV3i6Ytiwo1iA48SK2Gx7ruXP9oe+LOaFxxWGr0bp1TVPW4G47qWrsDDA5/Ls/f5TYez+qfukWxieRVXfaC21iByHqoBxjlAvIiRAmREQEREBERAREQEREBERAREQPHWaZLq3qcZrtRkceqMCpH6Gctb4Rv3hxrV7vPhLVEvjPLIDgE+4I+gnWJ8wPztx/hB4frX0pYsqAFHIA3oyhgcD3yPqpnnpbyvNefqpnRfjBwkGurXKPFU4psI863OUJ+jZH9+cksuI6cjAcauFrhFBDMcEenrLOnR1pWENeckDDEYZsE8/ovn+npKvhwZ7DYRnB2j16E8vfkP0My7NY/NAMFQSDZheXLPXqeSjlg8oGwO1KIC6r3alsDljPPA/QE/pK/T6zu7DYD42OawAMDYUcAeWCGwB6j3lRwxSfumOBvy+5SQzJ8o8h5knnn5fLrn1U97YQMciyhMhfxbRjJ9FEDbOEcRGo+7oXa7NkDqic8vjPMJ0OPUYm66HToqfZS27bUAy5G/YwK7j6ZwZR9nK6Ka2sGGuwibUBywC+HBPmSGJ9wRz2yn0+vtTVG0kli+58HG5QF3ID6Dwj6EQNj7O6bUU6mxUIYU1lcHILbiDXzPLngn25yz1+sRLUViM2IEKkhc2IM5LlTsDKu1iOeEGOeJjDtBQqsKz3jrhSteGJ64Bc+HlzJyeWfcZ5p2641cbFZlVWrtBVUbfkYzhmHTOMYx6wOqaDS2gDvn32q77LKwFD0qygbioCg+BcqoHPn6zJTYiClmZWSzq4y+SxcAEDDAAk+eB1mtcE7VaWzSr95WXNedp7tXSw/NkMwJG7xfXofKWHCO0OlvTD2V98SEda3R+fIl1Kc8tjJyo5r54GQ3HS3MWKt0xuRvMjzB+n7jMuaPo+JuOIpWWBqZUalvMswIYHHs//pm8QEREBERAREQET5n1AREQERPmB9RPmIH1IEiSIFB230i3aCylzhbGRcjGQe8VgRkHHMehnIOM9jBVULTq1BsbbVUyeNvMncHwABjnjz6cxOwdpdbSqbbGG2rF9gBIwq81yRzGT0A5nl6zjfF+LrqrXew+EgpXWAFFQ3Yx6ZAO7645wMDTHTU1tus2lCuCebN+LKqDzOc+vTpPS/hgewPXySz5lwQV8Oct7dc9OvLrmYbaz7vZchdGZsu+QEyQBsfnnlzyPUzN0GudUfeUKVqy5UYA2nAXOcE4HPHTl1zAruLagJammr+SsZPuT6+p6n840Gp22PZYNtaKLD5kn+ip8i2PylVo7e8vaxurHP5Hp/CZ2t0ygEtvUEcnUlkz5Bl/0gbN2b7SCt0Fm1FsWzuxgLtZwFVzzwFwuxfQAe5ntrnsscpsbepLqK8MSrBRgEdc7RNX4Ww1OqHMBgo2FlwhKDCjrlfabJw/S10WoXpY2vhRlwaw78izefQ9MYgfDcR1GkOHbfvJKgbcKAMKVUdBk5PsFHrFmgo1jrUXVLNZYq1uq5q3lSVyM+E7lYY/r+cjjGuLqtlFaMPCqhmU2B25HIJztJx+mZVcVKqqMuCUsSwKucs5bJCgDl09ffz5B1OrsRUgFYasaQKU7ru9zs+0tuZ2LbvEM7ceXnKa/sFVpy+q02DsWu6mtjld25g68wc58BUH+kR6TcdJr87aLnJvpqSy3OMF3XGSfMjIBPTxj8q/ivFBRTalj7N5IRmHhrpxWgI681Lg+5HpA17h2oF+r0wrABTUI+1ceGtnbK5HL5cZx55nXJyLsppmr1mnUoqsX2MlYOxAiHlnzPLry6TrcD6ifMnMCYiICIiB8xPiyxUUuxwqgsxPQKBkn9JT/wDFvDs4+1LkYBGHzkkKOWPUgfUiBdxKL/i/h3X7WnPB/H0Khh5f0WB+hBlxpdVXdWtlbh0cbkdehHqIHrERAGREQEkT5lP2q4sdJpWsTHeMy117sY3MeZweuFDHHtA5n8QtQU1T6dmIRrO/sxnc+RmpB64yT+npNDqqG5lcncdoUY82JA3c8EHmPzllxXVWWu7P4zYxc2Mycgcncxzkch64mDoxkZKurtnuwuwrtzuyMnOcnOR5QPTh1j96ETwnG0ltz42jPIZAxMbtBr1A+z1tnB+8b1bPPpyyT1ljZY4DbQvfN/KNWMKufzOX5/tPqZqesTDHPXqSepMDI4QPGZba+6vGDkNjy3DMrODjDZ9ZZ65O8euvHJ3G72A5kfoD+kDG4agKuwPiLYCnbju0VmZjnqM7Rym08GRAxKAkouWXcpQZ/o+jZGR9DNb0GlAstDnCadDgDmWydyjn1JxM3h7rkUo23YW3hz8zbGQnO0f0unoTAnUFDqVRSAA7DaVVXRkzgAgnPiGPpMPi+tZO7KN4qnVl3AfMuCCQevMefrLe2hQRgB7WyVc5Ldcb3J5Z68h6Ga1xqxXtbacjcQD6wLrgnaLWB23BbRezE95825iS21vIczPntNxW+3FV9jNUpASoMSocciwLZJwMjmfOfHZLShtSoPPZl2J54Ven05/umTw/hlmv14rqBzYx25HhROrO2OigZPvkDriBvnwi0Njsb3Dd3pwURmOS1rjBGfMKuf8AGJ1YTC4Tw6rSUJp6hhK1wPVm6szerE5J+szYCIiAn1PiTARIiB56nZ3b958mxt+emzB3Z9sZnJKfsfIt3akhSy4bm4psLspA6/aBp2yfPnOt21K6MjDKupRhnGVYYIyPYzWz2A4WetD+n851vT/zIGlqnDmdGGzuyyKWwDmnN6HGB02DTcvIKgGcNOmcA2fZKe7xs7pcFc43Y8WP726Uy9gOFgAChwFwFA1OswMdMDvOU2HQaOvT1JTUu2utdqKSzEL7sxJP1JgZESIgTmREQE5N8YNXcupprA+67gug65sLMrnHsor/AMXvOsyi7W9na+IUd2W2W1nfTbjdsYjBBGRlSOoyOgPlA4Jp135BUeM7SG5IFwBt5fiPqP8ASfHE7O7X7t3Ll9o3spAYgA7dvI8h+U2/i3wv4hWN1DJeOhRG2P19HIUjz+bPtNN7QcG1Wk1CUatQr92LFRWVgFZmXmV5Z8J6ekC44VUorwep/aZqnHKttuPWbjwus7Rmaz2j8Wq2j8IgRoKcKDM6hCljXNjYlZx0z7/7954aZcLz9J4XaxTlOqk4PLPhHzf5ZgZdGFpFlpIN9ocquNx55VQT0HIGeGk1zbiAuSSfnKqg5k5cgbmx9Z8X6lXdMj7qtfCG+Ut0A98cp8VIzuDkZLbggAC9ckn6DzP7ekC21upxps7t1rNhXClfBzzt89ozgZ85QCkrg7ev4uv/AOTJ4pqmFg9F8IXywOv7Z5VWlmKhSrAZwGOMY/35QL/s7Z3fePg5KCtAvUs/IYHUkjp9TO0diuzI0VbWWDOp1GDYcDwIPlqXHp1J8z7ATWPhh2ZJRdXeCURt1Ct0awAL3n0XBC+5J8hOnQJESJMBERARIiBMSIgJMRAiSZEQEREBAiIAREQJE4f8Yv8AxWv/AKOv/wCS+IgePCflH0/hNN4z/PH/ACiIHuvy/wB0/ulFb8o/sj+MRAin5W/u/vl5wX+UP1X/ALxEQMTW/MfoZk6D+cH6/wD1iIH6X4F/NKP+nq/7FmcIiBEmIgRJiIAyIiAiIgf/2Q==",
					ReleaseDate = "today",
					Score = 110
                },
				new ()
				{
					Name = "Divina Commmedia",
					Cover = "data:image/jpeg;base64,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",
                    ReleaseDate = "today",
					Score = 1000
                },
				new ()
				{
					Name = "Cultura Italiana",
					Cover = "data:image/jpeg;base64,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",
					ReleaseDate = "today",
					Score = 70
                }
			};
		}


    }
}
